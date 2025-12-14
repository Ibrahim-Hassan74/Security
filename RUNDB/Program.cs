using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using Microsoft.Data.SqlClient;

namespace PreparePasswordsDB {
    class Program {
        // USER CONFIG
        const string ConnectionString = "Data Source=.;Initial Catalog=Security;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
        const string RockYouPath = @".\rockyou.txt";  // Relative path - place rockyou.txt in .\Security\RUNDB\bin\Debug\net8.0\

        // Tunables
        // Adjust memory used per chunk. DEFAULT: ~400 MB.
        const long MAX_CHUNK_BYTES = 400L * 1024 * 1024;
        const int HASH_BYTES = 20;
        static readonly long TARGET_HASHES_PER_CHUNK = Math.Max(1000L, MAX_CHUNK_BYTES / HASH_BYTES);

        // Temp file naming
        static string TempFolder => Path.Combine(Path.GetTempPath(), "sha1_chunks_" + Environment.UserName + "_" + ProcessId);
        static int ProcessId => System.Diagnostics.Process.GetCurrentProcess().Id;

        static void Main() {
            try {
                Directory.CreateDirectory(TempFolder);
                Console.WriteLine($"Temp folder: {TempFolder}");
                Console.WriteLine("Step 1/5: Read rockyou.txt, compute SHA1, create sorted unique chunk files...");

                var chunkFiles = CreateSortedChunks(RockYouPath);

                Console.WriteLine($"Created {chunkFiles.Count} chunk file(s). Step 2/5: Merging chunks -> final sorted-unique file...");
                string finalFile = Path.Combine(TempFolder, "final_sorted_unique.bin");
                MergeChunks(chunkFiles, finalFile);

                Console.WriteLine("Step 3/5: Creating target table (heap) and bulk inserting final file...");
                EnsureEmptyTargetTable();

                BulkInsertFromBinaryFile(finalFile);

                Console.WriteLine("Step 4/5: Creating clustered primary key on testing_passwords (table is sorted => fast)...");
                CreateClusteredPrimaryKey();

                Console.WriteLine("Step 5/5: Cleanup temp files...");
                TryDeleteTempFiles(TempFolder);

                Console.WriteLine("Done. Data is loaded into database 'Pwned' table 'testing_passwords' column 'passwords'.");
                Console.WriteLine();
                Console.WriteLine("Example: How to query (code snippet) — shown below and executed as a demo lookup.");
                DemoLookup("password"); // demo sample
            }
            catch (Exception ex) {
                Console.Error.WriteLine("ERROR: " + ex);
            }
        }

        // -------------------------
        // Phase 1: read -> chunked sorted unique files
        // -------------------------
        static List<string> CreateSortedChunks(string inputPath) {
            var chunkFiles = new List<string>();
            var buffer = new List<byte[]>((int)Math.Min(1000000, TARGET_HASHES_PER_CHUNK));
            long linesRead = 0;
            using var sha1 = SHA1.Create();

            using var reader = new StreamReader(new FileStream(inputPath, FileMode.Open, FileAccess.Read, FileShare.Read), leaveOpen: false);
            string? line;
            while ((line = reader.ReadLine()) != null) {
                linesRead++;
                string trimmed = line.Trim(); // remove leading/trailing spaces as requested
                byte[] bytes = System.Text.Encoding.UTF8.GetBytes(trimmed); // use UTF-8 bytes of trimmed password
                byte[] hash = sha1.ComputeHash(bytes); // 20 bytes
                                                       // store as 20-byte array
                buffer.Add(hash);

                if (buffer.Count >= TARGET_HASHES_PER_CHUNK) {
                    string chunk = WriteChunkFile(buffer, chunkFiles.Count);
                    chunkFiles.Add(chunk);
                    buffer.Clear();
                    Console.WriteLine($"  Read {linesRead:N0} lines -> wrote chunk {chunkFiles.Count} ({chunk})");
                }

                if ((linesRead & 0x1FFFF) == 0) // progress every ~131k lines
                    Console.WriteLine($"  Progress: read {linesRead:N0} lines, buffered {buffer.Count:N0} hashes");
            }

            if (buffer.Count > 0) {
                string chunk = WriteChunkFile(buffer, chunkFiles.Count);
                chunkFiles.Add(chunk);
                Console.WriteLine($"  Final chunk written: {chunk}");
                buffer.Clear();
            }

            Console.WriteLine($"Total lines read: {linesRead:N0} ; chunk files: {chunkFiles.Count}");
            return chunkFiles;
        }

        static string WriteChunkFile(List<byte[]> buffer, int chunkIdx) {
            // Sort + unique the buffer in-memory
            buffer.Sort(ByteArrayComparer.Instance);
            // Remove duplicates in-place:
            int uniqueCount = 0;
            for (int i = 0; i < buffer.Count; ++i) {
                if (uniqueCount == 0 || !ByteArrayComparer.Instance.Equals(buffer[i], buffer[uniqueCount - 1])) {
                    buffer[uniqueCount++] = buffer[i];
                }
            }
            if (uniqueCount < buffer.Count)
                buffer.RemoveRange(uniqueCount, buffer.Count - uniqueCount);

            string fname = Path.Combine(TempFolder, $"chunk_{chunkIdx:D4}.bin");
            using var fs = new FileStream(fname, FileMode.Create, FileAccess.Write, FileShare.None, 64 * 1024);
            foreach (var b in buffer) {
                fs.Write(b, 0, HASH_BYTES);
            }
            fs.Flush(true);
            return fname;
        }

        // -------------------------
        // Phase 2: merge sorted chunk files to one final sorted unique file
        // -------------------------
        static void MergeChunks(List<string> chunkFiles, string outputFile) {
            if (chunkFiles.Count == 0)
                throw new InvalidOperationException("No chunk files to merge.");

            if (chunkFiles.Count == 1) {
                // already sorted+unique -> just copy/rename
                File.Copy(chunkFiles[0], outputFile, overwrite: true);
                return;
            }

            // Open readers
            var readers = new List<BinaryReader>();
            foreach (var f in chunkFiles)
                readers.Add(new BinaryReader(new FileStream(f, FileMode.Open, FileAccess.Read, FileShare.Read, 64 * 1024)));

            try {
                // priority queue (min-heap)
                var pq = new SimpleMinHeap();
                for (int i = 0; i < readers.Count; ++i) {
                    if (TryReadHash(readers[i], out byte[]? h)) {
                        pq.Push(new HeapItem { Key = h!, ReaderIndex = i });
                    }
                }

                using var outFs = new FileStream(outputFile, FileMode.Create, FileAccess.Write, FileShare.None, 64 * 1024);
                byte[]? lastWritten = null;
                long written = 0;
                while (pq.Count > 0) {
                    var item = pq.Pop();
                    // write if not equal to lastWritten
                    if (lastWritten == null || !ByteArrayComparer.Instance.Equals(item.Key, lastWritten)) {
                        outFs.Write(item.Key, 0, HASH_BYTES);
                        lastWritten = item.Key;
                        written++;
                        if ((written & 0x3FFFF) == 0)
                            Console.WriteLine($"  Merge: written {written:N0} unique hashes so far...");
                    }

                    // advance reader
                    if (TryReadHash(readers[item.ReaderIndex], out byte[]? next)) {
                        pq.Push(new HeapItem { Key = next!, ReaderIndex = item.ReaderIndex });
                    }
                    else {
                        // reader finished
                        readers[item.ReaderIndex].Dispose();
                        // delete its chunk file to save space
                        try { File.Delete(chunkFiles[item.ReaderIndex]); } catch { }
                    }
                }

                outFs.Flush(true);
                Console.WriteLine($"Merge complete. Total unique hashes written: {written:N0}");
            }
            finally {
                foreach (var r in readers) r.Dispose();
            }
        }

        static bool TryReadHash(BinaryReader br, out byte[]? hash) {
            hash = null;
            var buf = new byte[HASH_BYTES];
            int read = br.Read(buf, 0, HASH_BYTES);
            if (read == HASH_BYTES) { hash = buf; return true; }
            return false;
        }

        // -------------------------
        // Phase 3: prepare target table (heap) empty
        // -------------------------
        static void EnsureEmptyTargetTable() {
            using var conn = new SqlConnection(ConnectionString);
            conn.Open();

            // Create database objects if not exist, and empty the table
            string createTableSql = @"
IF OBJECT_ID('dbo.pwned_passwords','U') IS NULL
BEGIN
    CREATE TABLE dbo.pwned_passwords
    (
        passwords BINARY(20) NOT NULL
    );
END
ELSE
BEGIN
    TRUNCATE TABLE dbo.pwned_passwords;
END
";
            using var cmd = new SqlCommand(createTableSql, conn);
            cmd.CommandTimeout = 0;
            cmd.ExecuteNonQuery();
            conn.Close();
            Console.WriteLine("Target table dbo.pwned_passwords is ready (empty).");
        }

        // -------------------------
        // Phase 4: bulk insert final file into heap using SqlBulkCopy with a custom IDataReader
        // -------------------------
        static void BulkInsertFromBinaryFile(string finalFile) {
            using var conn = new SqlConnection(ConnectionString);
            conn.Open();

            // Read finalFile streaming via IDataReader implementation
            using var rdr = new BinaryHashDataReader(finalFile);
            using var bcp = new SqlBulkCopy(conn, SqlBulkCopyOptions.TableLock | SqlBulkCopyOptions.FireTriggers, null) {
                DestinationTableName = "dbo.pwned_passwords",
                BatchSize = 10000,
                BulkCopyTimeout = 0
            };
            // map source ordinal 0 -> destination ordinal 0 (passwords)
            bcp.ColumnMappings.Add(0, 0);

            Console.WriteLine("Starting SqlBulkCopy...");
            long before = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            bcp.WriteToServer(rdr);
            long after = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            Console.WriteLine($"SqlBulkCopy finished. Duration: {after - before} seconds.");
            conn.Close();
        }

        // -------------------------
        // Phase 5: create clustered PK (fast because data is sorted)
        // -------------------------
        static void CreateClusteredPrimaryKey() {
            using var conn = new SqlConnection(ConnectionString);
            conn.Open();

            // If PK exists, drop it and recreate as clustered on the column
            string sql = @"
IF EXISTS (SELECT 1 FROM sys.indexes i JOIN sys.objects o ON i.object_id = o.object_id
           WHERE o.object_id = OBJECT_ID('dbo.pwned_passwords') AND i.is_primary_key = 1)
BEGIN
    PRINT 'Primary key already exists; skipping creation.';
END
ELSE
BEGIN
    ALTER TABLE dbo.pwned_passwords
    ADD CONSTRAINT PK_pwned_passwords_passwords PRIMARY KEY CLUSTERED (passwords);
END
";
            using var cmd = new SqlCommand(sql, conn);
            cmd.CommandTimeout = 0;
            cmd.ExecuteNonQuery();
            conn.Close();
            Console.WriteLine("Clustered primary key created on dbo.pwned_passwords(passwords).");
        }

        // -------------------------
        // Cleanup
        // -------------------------
        static void TryDeleteTempFiles(string folder) {
            try {
                if (Directory.Exists(folder)) {
                    Directory.Delete(folder, true);
                    Console.WriteLine("Temp folder deleted.");
                }
            }
            catch (Exception ex) {
                Console.WriteLine("Warning: failed to delete temp folder: " + ex.Message);
            }
        }

        // -------------------------
        // Example retrieval / lookup
        // -------------------------
        static void DemoLookup(string plaintext) {
            Console.WriteLine($"Demo lookup for plaintext: \"{plaintext}\"");

            // compute SHA1
            byte[] hash;
            using (var sha = SHA1.Create()) {
                hash = sha.ComputeHash(System.Text.Encoding.UTF8.GetBytes(plaintext.Trim()));
            }

            // show hex
            Console.WriteLine("SHA1(hex): " + BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant());

            // Query DB
            using var conn = new SqlConnection(ConnectionString);
            conn.Open();
            using var cmd = new SqlCommand("SELECT COUNT(1) FROM dbo.pwned_passwords WHERE passwords = @h", conn);
            var p = cmd.Parameters.Add("@h", SqlDbType.Binary, 20);
            p.Value = hash;
            object? res = cmd.ExecuteScalar();
            long count = (res == null || res == DBNull.Value) ? 0 : Convert.ToInt64(res);
            Console.WriteLine(count > 0 ? $"FOUND ({count} rows)" : "NOT FOUND");
        }

        // -------------------------
        // Helper classes
        // -------------------------
        class ByteArrayComparer : IComparer<byte[]>, IEqualityComparer<byte[]> {
            public static readonly ByteArrayComparer Instance = new ByteArrayComparer();
            public int Compare(byte[]? x, byte[]? y) {
                if (ReferenceEquals(x, y)) return 0;
                if (x == null) return -1;
                if (y == null) return 1;
                for (int i = 0; i < HASH_BYTES; ++i) {
                    int a = x[i], b = y[i];
                    if (a != b) return a - b;
                }
                return 0;
            }
            public bool Equals(byte[]? x, byte[]? y) => Compare(x, y) == 0;
            public int GetHashCode(byte[] obj) => BitConverter.ToInt32(obj, 0);
        }

        class HeapItem { public byte[]? Key; public int ReaderIndex; }

        // Minimal binary min-heap for HeapItem using ByteArrayComparer
        class SimpleMinHeap {
            List<HeapItem> _data = new List<HeapItem>();
            public int Count => _data.Count;
            public void Push(HeapItem it) {
                _data.Add(it);
                int i = _data.Count - 1;
                while (i > 0) {
                    int p = (i - 1) >> 1;
                    if (ByteArrayComparer.Instance.Compare(_data[p].Key, _data[i].Key) <= 0) break;
                    var tmp = _data[p]; _data[p] = _data[i]; _data[i] = tmp;
                    i = p;
                }
            }
            public HeapItem Pop() {
                var top = _data[0];
                int n = _data.Count - 1;
                _data[0] = _data[n];
                _data.RemoveAt(n);
                n--;
                int i = 0;
                while (true) {
                    int l = i * 2 + 1, r = l + 1, smallest = i;
                    if (l <= n && ByteArrayComparer.Instance.Compare(_data[l].Key, _data[smallest].Key) < 0) smallest = l;
                    if (r <= n && ByteArrayComparer.Instance.Compare(_data[r].Key, _data[smallest].Key) < 0) smallest = r;
                    if (smallest == i) break;
                    var tmp = _data[i]; _data[i] = _data[smallest]; _data[smallest] = tmp;
                    i = smallest;
                }
                return top;
            }
        }

        // BinaryHashDataReader: streams 20-byte binary rows for SqlBulkCopy
        class BinaryHashDataReader : IDataReader {
            private readonly FileStream _fs;
            private readonly BinaryReader _br;
            private bool _closed;
            private byte[]? _current;
            private const int HASH_BYTES = 20;

            public BinaryHashDataReader(string path) {
                _fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read, 64 * 1024);
                _br = new BinaryReader(_fs);
                _closed = false;
                _current = null;
            }

            // IDataReader: read next row
            public bool Read() {
                var buf = new byte[HASH_BYTES];
                int r = _br.Read(buf, 0, HASH_BYTES);
                if (r == HASH_BYTES) { _current = buf; return true; }
                _current = null;
                return false;
            }

            // Return the object for column index i (only 1 column here)
            public object GetValue(int i) {
                if (i != 0) throw new IndexOutOfRangeException();
                if (_current == null) throw new InvalidOperationException("No current row. Call Read() first.");
                return _current;
            }

            public int FieldCount => 1;

            public void Close() => Dispose();

            public DataTable GetSchemaTable() {
                var dt = new DataTable("SchemaTable");
                // minimal schema info for a single binary column named 'passwords'
                dt.Columns.Add("ColumnName", typeof(string));
                dt.Columns.Add("ColumnOrdinal", typeof(int));
                dt.Columns.Add("ColumnSize", typeof(int));
                dt.Columns.Add("NumericPrecision", typeof(short));
                dt.Columns.Add("NumericScale", typeof(short));
                dt.Columns.Add("DataType", typeof(Type));
                dt.Columns.Add("AllowDBNull", typeof(bool));

                var row = dt.NewRow();
                row["ColumnName"] = "passwords";
                row["ColumnOrdinal"] = 0;
                row["ColumnSize"] = HASH_BYTES;
                row["NumericPrecision"] = DBNull.Value;
                row["NumericScale"] = DBNull.Value;
                row["DataType"] = typeof(byte[]);
                row["AllowDBNull"] = false;
                dt.Rows.Add(row);
                return dt;
            }

            #region Other IDataReader / IDataRecord members (simple implementations)
            public void Dispose() {
                if (!_closed) {
                    _br.Close();
                    _fs.Close();
                    _closed = true;
                }
            }

            public bool NextResult() => false;
            public int Depth => 0;
            public bool IsClosed => _closed;
            public int RecordsAffected => -1;

            public string GetName(int i) => i == 0 ? "passwords" : throw new IndexOutOfRangeException();
            public string GetDataTypeName(int i) => i == 0 ? "binary" : throw new IndexOutOfRangeException();
            public Type GetFieldType(int i) => i == 0 ? typeof(byte[]) : throw new IndexOutOfRangeException();
            public object this[int i] => GetValue(i);
            public object this[string name] => GetValue(GetOrdinal(name));
            public int GetOrdinal(string name) => name == "passwords" ? 0 : -1;

            // unsupported / not used - throw to indicate not implemented
            public bool GetBoolean(int i) => throw new NotSupportedException();
            public byte GetByte(int i) => throw new NotSupportedException();
            public long GetBytes(int i, long fieldOffset, byte[] buffer, int bufferoffset, int length) => throw new NotSupportedException();
            public char GetChar(int i) => throw new NotSupportedException();
            public long GetChars(int i, long fieldoffset, char[] buffer, int bufferoffset, int length) => throw new NotSupportedException();
            public IDataReader GetData(int i) => throw new NotSupportedException();
            public DateTime GetDateTime(int i) => throw new NotSupportedException();
            public decimal GetDecimal(int i) => throw new NotSupportedException();
            public double GetDouble(int i) => throw new NotSupportedException();
            public float GetFloat(int i) => throw new NotSupportedException();
            public Guid GetGuid(int i) => throw new NotSupportedException();
            public short GetInt16(int i) => throw new NotSupportedException();
            public int GetInt32(int i) => throw new NotSupportedException();
            public long GetInt64(int i) => throw new NotSupportedException();
            public string GetString(int i) => throw new NotSupportedException();
            public bool IsDBNull(int i) => throw new NotSupportedException();
            public int GetValues(object[] values) {
                if (_current == null) return 0;
                values[0] = _current;
                return 1;
            }
            #endregion
        }

    }
}