using Security.Algorithms;
using Security.Extensions;
using Security.Models;
using Security.ServiceContract;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Security.Service
{
    public class HillService : ICipherService
    {
        public string Id => "Hill";
        public string Name => "Hill Cipher (2x2)";
        public bool RequiresKey => true;
        public string KeyHint => "Four integers separated by commas (e.g. \"3,2,5,7\")";

        public string GenerateKey()
        {
            var rnd = new Random();
            for (int tries = 0; tries < 10000; ++tries)
            {
                int a = rnd.Next(0, 27);
                int b = rnd.Next(0, 27);
                int c = rnd.Next(0, 27);
                int d = rnd.Next(0, 27);

                int det = ((a * d - b * c) % 27 + 27) % 27;
                if (det == 0) continue;
                if (MathX.Gcd(det, 27) == 1)
                {
                    return $"{a},{b},{c},{d}";
                }
            }
            return null;
        }

        public EncryptionResult Encrypt(string plaintext, string key = null)
        {
            if (string.IsNullOrWhiteSpace(plaintext))
                throw new ArgumentException("Plaintext cannot be empty.", nameof(plaintext));

            if (string.IsNullOrWhiteSpace(key))
                throw new ArgumentException("Hill cipher requires a 4-integer key.", nameof(key));

            var matrixValues = ParseKey(key);

            var ciphertext = HillCipher.Encrypt(plaintext, matrixValues);

            return new EncryptionResult
            {
                AlgorithmId = Id,
                Ciphertext = ciphertext,
                UsedKey = key
            };
        }

        public string Decrypt(string ciphertext, string key)
        {
            if (string.IsNullOrWhiteSpace(ciphertext))
                throw new ArgumentException("Ciphertext cannot be empty.", nameof(ciphertext));

            if (string.IsNullOrWhiteSpace(key))
                throw new ArgumentException("Hill cipher requires a 4-integer key.", nameof(key));

            var matrixValues = ParseKey(key);

            var plain = HillCipher.Decrypt(ciphertext, matrixValues);
            return plain;
        }

        private static List<int> ParseKey(string key)
        {
            var parts = key.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                           .Select(p => p.Trim())
                           .ToArray(); // 3,2,5,7

            if (parts.Length != 4)
                throw new ArgumentException("The Hill key must contain exactly 4 integers separated by commas (e.g. \"a,b,c,d\").");

            var vals = new List<int>(4);
            foreach (var p in parts)
            {
                if (!int.TryParse(p, out int v))
                    throw new ArgumentException("Key parts must be integers.");
                v = ((v % 27) + 27) % 27;
                vals.Add(v);
            }

            int[,] m = { { vals[0], vals[1] }, { vals[2], vals[3] } };
            int det = ((m[0, 0] * m[1, 1] - m[0, 1] * m[1, 0]) % 27 + 27) % 27;
            if (det == 0 || MathX.Gcd(det, 27) != 1)
                throw new ArgumentException("Provided matrix is not invertible modulo 27. Choose values with determinant coprime with 27.");

            return vals;
        }

    }
}
