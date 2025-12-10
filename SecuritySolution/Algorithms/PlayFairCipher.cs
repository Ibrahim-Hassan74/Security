using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security.Algorithms
{
    public static class PlayFairCipher
    {
        private static readonly char Filler = '9';
        private static readonly int MatrixSize = 6;
        private static char[,] Matrix;
        private static Dictionary<char, (int row, int col)> LookUp;
        private static List<string> EnableDictionary;
        public static (string, string) Preproccing(string text, string key)
        {
            if (String.IsNullOrEmpty(text)) throw new ArgumentNullException("text");
            if (String.IsNullOrEmpty(key)) throw new ArgumentNullException("key");
            if (!ValidText(text))
                throw new ArgumentException("text must contain only upper case english letters");
            if (!ValidText(key))
                throw new ArgumentException("key must contain only upper case english letters");

            text = text.ToUpper();
            key = key.ToUpper();

            Matrix = new char[MatrixSize, MatrixSize];
            LookUp = new Dictionary<char, (int, int)>();

            var visitedLetters = new SortedSet<Char>();

            for (char i = 'A'; i <= 'Z'; ++i)
                visitedLetters.Add(i);
            for (char i = '0'; i <= '9'; ++i)
                visitedLetters.Add(i);

            int keyIndex = 0;
            for (int i = 0; i < MatrixSize; i++)
            {
                for (int j = 0; j < MatrixSize; j++)
                {
                    while (keyIndex < key.Length && !visitedLetters.Contains(key[keyIndex]))
                        keyIndex++;
                    if (keyIndex < key.Length)
                    {
                        Matrix[i, j] = key[keyIndex];
                        LookUp[key[keyIndex]] = (i, j);
                        visitedLetters.Remove(key[keyIndex]);
                        ++keyIndex;
                    }
                    else
                    {
                        Matrix[i, j] = visitedLetters.Min;
                        LookUp[visitedLetters.Min] = (i, j);
                        visitedLetters.Remove(visitedLetters.Min);
                    }
                }
            }

            try
            {
                EnableDictionary = File.ReadAllLines("E:\\aspnetcore\\code\\Security\\SecuritySolution\\Algorithms\\enable.txt").ToList();
                EnableDictionary.Sort((a, b) => a.Length.CompareTo(b.Length));
                EnableDictionary = EnableDictionary.Select(s => s.ToUpper()).ToList();
            }
            catch (IOException ex)
            {
                throw new Exception("Could not read file enable.txt", ex);
            }
            return (text, key);
        }

        public static string Encrypt(string Text, string Key)
        {
            var (text, key) = Preproccing(Text, Key);
            text = FixText(text);
            var sb = new StringBuilder();
            for (int i = 0; i < text.Length; i += 2)
            {
                var (a, b) = GetPair(text[i], text[i + 1], true);
                sb.Append(a);
                sb.Append(b);
            }
            return sb.ToString();
        }

        public static (string, List<string>) Decrypt(string Text, string Key)
        {
            var (text, key) = Preproccing(Text, Key);
            var sb = new StringBuilder();
            for (int i = 0; i < text.Length; i += 2)
            {
                var (a, b) = GetPair(text[i], text[i + 1], false);
                sb.Append(a);
                sb.Append(b);
            }
            var decryptedText = Clean(sb.ToString());
            return (decryptedText, CloseWords(decryptedText));
        }

        private static (char, char) GetPair(char a, char b, bool encrypt)
        {
            var (ai, aj) = LookUp[a];
            var (bi, bj) = LookUp[b];
            int offset = encrypt ? 1 : -1;
            if (ai == bi)
                return (Matrix[ai, (aj + offset + MatrixSize) % MatrixSize], Matrix[bi, (bj + offset + MatrixSize) % MatrixSize]);
            else if (aj == bj)
                return (Matrix[(ai + offset + MatrixSize) % MatrixSize, aj], Matrix[(bi + offset + MatrixSize) % MatrixSize, bj]);
            else
                return (Matrix[ai, bj], Matrix[bi, aj]);
        }

        private static List<string> CloseWords(string word)
        {
            int start = GetFirstIndex(word.Length - word.Count(c => c == Filler));
            int end = GetLastIndex(word.Length);
            var set = new SortedSet<(int, string)>();
            for (int i = start; i <= end; ++i)
            {
                int wordScore = WordScore(EnableDictionary[i], word);
                set.Add((wordScore, EnableDictionary[i]));
            }
            var res = new List<string>();
            foreach (var (sc, w) in set)
            {
                res.Add(w);
                if (res.Count == 10) break;
            }
            return res;
        }
        public static int WordScore(string dictionaryWord, string word)
        {
            if (dictionaryWord == word)
                return int.MinValue;
            int score = 0, idx = 0;
            for (int i = 0; i < Math.Min(dictionaryWord.Length, word.Length); ++i)
            {
                if (dictionaryWord[i] != word[i])
                    break;
                score -= 1;
            }
            foreach (var c in word)
            {
                if (idx < dictionaryWord.Length && c == dictionaryWord[idx])
                    ++idx;
                else if (Char.IsDigit(c))
                    continue;
                else
                    score += 1;
            }
            return score;
        }

        private static string Clean(string word)
        {
            var sb = new StringBuilder();
            foreach (var c in word)
            {
                if (!Char.IsDigit(c))
                    sb.Append(c);
            }
            return sb.ToString();
        }

        private static int GetFirstIndex(int wordLength)
        {
            int l = 0, r = EnableDictionary.Count - 1, mid, res = -1;
            while (l <= r)
            {
                mid = (l + r) >> 1;
                if (EnableDictionary[mid].Length >= wordLength)
                {
                    r = mid - 1;
                    res = mid;
                }
                else
                {
                    l = mid + 1;
                }
            }
            return res;
        }

        private static int GetLastIndex(int wordLength)
        {
            int l = 0, r = EnableDictionary.Count - 1, mid, res = -1;
            while (l <= r)
            {
                mid = (l + r) >> 1;
                if (EnableDictionary[mid].Length <= wordLength)
                {
                    l = mid + 1;
                    res = mid;
                }
                else
                {
                    r = mid - 1;
                }
            }
            return res;
        }

        private static string FixText(string text)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(text[0]);
            for (int i = 1; i < text.Length; i++)
            {
                if (text[i] == sb[sb.Length - 1] && sb.Length % 2 != 0)
                    sb.Append(Filler);
                sb.Append(text[i]);
            }
            if (sb.Length % 2 != 0)
                sb.Append(Filler);
            return sb.ToString();
        }


        private static bool ValidChar(char c) => (c >= 'A' && c <= 'Z');

        private static bool ValidText(string text)
        {
            foreach (char c in text)
            {
                if (!(ValidChar(c) || Char.IsDigit(c)))
                    return false;
            }
            return true;
        }
    }
}
