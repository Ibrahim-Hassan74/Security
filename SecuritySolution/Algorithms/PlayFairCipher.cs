using System.Text;

namespace EncryptionAlgos {
    public static class PlayFairCipher {
        private static char[,] Matrix;
        private static Dictionary<char, (int row, int col)> LookUp;
        private static List<string> EnableDictionary;
        public static (string, string) Preproccing(string text, string key) {
            if (String.IsNullOrEmpty(text)) throw new ArgumentNullException("text");
            if (String.IsNullOrEmpty(key)) throw new ArgumentNullException("key");
            if (!ValidText(text))
                throw new ArgumentException("text must contain only lower and upper case english letters");
            if (!ValidText(key))
                throw new ArgumentException("key must contain only lower and upper case english letters");

            text = NormalizeText(text);
            key = NormalizeText(key);

            Matrix = new char[5, 5];
            LookUp = new Dictionary<char, (int, int)>();

            var visitedLetters = new SortedSet<Char>();

            for (char i = 'A'; i <= 'Z'; ++i) {
                if (i == 'J')
                    continue;
                visitedLetters.Add(i);
            }

            int keyIndex = 0;
            for (int i = 0; i < 5; i++) {
                for (int j = 0; j < 5; j++) {
                    while (keyIndex < key.Length && !visitedLetters.Contains(key[keyIndex]))
                        keyIndex++;
                    if (keyIndex < key.Length) {
                        Matrix[i, j] = key[keyIndex];
                        LookUp[key[keyIndex]] = (i, j);
                        visitedLetters.Remove(key[keyIndex]);
                        ++keyIndex;
                    }
                    else {
                        Matrix[i, j] = visitedLetters.Min;
                        LookUp[visitedLetters.Min] = (i, j);
                        visitedLetters.Remove(visitedLetters.Min);
                    }
                }
            }

            try {
                EnableDictionary = File.ReadAllLines("D:\\VS Projects\\EncryptionAlgos\\EncryptionAlgos\\enable.txt").ToList();
                EnableDictionary.Sort((a, b) => a.Length.CompareTo(b.Length));
                EnableDictionary = EnableDictionary.Select(s => s.ToUpper()).ToList();
            }
            catch (IOException ex) {
                throw new Exception("Could not read file enable.txt", ex);
            }
            return (text, key);
        }

        public static string Encrypt(string Text, string Key) {
            var (text, key) = Preproccing(Text, Key);
            text = FixText(text);
            var sb = new StringBuilder();
            for (int i = 0; i < text.Length; i += 2) {
                var (a, b) = GetPair(text[i], text[i + 1], true);
                sb.Append(a);
                sb.Append(b);
            }
            return sb.ToString();
        }

        public static (string, List<string>) Decrypt(string Text, string Key) {
            var (text, key) = Preproccing(Text, Key);
            var sb = new StringBuilder();
            for (int i = 0; i < text.Length; i += 2) {
                var (a, b) = GetPair(text[i], text[i + 1], false);
                sb.Append(a);
                sb.Append(b);
            }
            var decryptedText = sb.ToString();
            return (decryptedText, CloseWords(decryptedText));
        }

        private static (char, char) GetPair(char a, char b, bool encrypt) {
            var (ai, aj) = LookUp[a];
            var (bi, bj) = LookUp[b];
            int offset = encrypt ? 1 : -1;
            if (ai == bi)
                return (Matrix[ai, (aj + offset + 5) % 5], Matrix[bi, (bj + offset + 5) % 5]);
            else if (aj == bj)
                return (Matrix[(ai + offset + 5) % 5, aj], Matrix[(bi + offset + 5) % 5, bj]);
            else
                return (Matrix[ai, bj], Matrix[bi, aj]);
        }

        private static List<string> CloseWords(string word) {
            int start = GetFirstIndex(word.Length - word.Count(c => c == 'X'));
            int end = GetLastIndex(word.Length);
            var set = new SortedSet<(int, string)>();
            for (int i = start; i <= end; ++i) {
                int wordScore = WordScore(EnableDictionary[i], word);
                set.Add((wordScore, EnableDictionary[i]));
                if (set.Count > 10)
                    set.Remove(set.Max);
            }
            var res = new List<string>();
            foreach (var (sc, w) in set)
                res.Add(w);
            return res;
        }

        private static int WordScore(string dictionaryWord, string word) {
            int score = 0, idx = 0;
            foreach (var c in word) {
                if (idx < dictionaryWord.Length && c == dictionaryWord[idx])
                    ++idx;
                else if (c == 'X')
                    ++score;
                else
                    score += 10;
            }
            return score;
        }

        private static int GetFirstIndex(int wordLength) {
            int l = 0, r = EnableDictionary.Count - 1, mid, res = -1;
            while (l <= r) {
                mid = (l + r) >> 1;
                if (EnableDictionary[mid].Length >= wordLength) {
                    r = mid - 1;
                    res = mid;
                }
                else {
                    l = mid + 1;
                }
            }
            return res;
        }

        private static int GetLastIndex(int wordLength) {
            int l = 0, r = EnableDictionary.Count - 1, mid, res = -1;
            while (l <= r) {
                mid = (l + r) >> 1;
                if (EnableDictionary[mid].Length <= wordLength) {
                    l = mid + 1;
                    res = mid;
                }
                else {
                    r = mid - 1;
                }
            }
            return res;
        }

        private static string FixText(string text) {
            StringBuilder sb = new StringBuilder();
            sb.Append(text[0]);
            for (int i = 1; i < text.Length; i++) {
                if (text[i] == sb[sb.Length - 1] && sb.Length % 2 != 0)
                    sb.Append('X');
                sb.Append(text[i]);
            }
            if (sb.Length % 2 != 0)
                sb.Append('X');
            return sb.ToString();
        }
        private static string NormalizeText(string text) {
            var sb = new StringBuilder(text);
            for (int i = 0; i < sb.Length; i++) {
                sb[i] = Char.ToUpper(sb[i]);
                if (sb[i] == 'J')
                    sb[i] = 'I';
            }
            return sb.ToString();
        }

        private static bool ValidText(string text) {
            foreach (char c in text) {
                if (!Char.IsUpper(c))
                    return false;
            }
            return true;
        }
    }
}
