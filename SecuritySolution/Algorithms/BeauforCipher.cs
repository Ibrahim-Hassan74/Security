using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security.Algorithms {
    public static class BeauforCipher {
        public static string Encrypt(string text, string key) {
            if (string.IsNullOrEmpty(text)) throw new ArgumentNullException("text");
            if (string.IsNullOrEmpty(key)) throw new ArgumentNullException("key");
            if (!ValidText(key)) throw new ArgumentException("key must contain only lower and upper case english letters");
            var sb = new StringBuilder(text.Length);
            int keyIdx = 0;
            foreach (char c in text) {
                if (!ValidChar(c)) {
                    sb.Append(c);
                    continue;
                }
                int P = Char.ToUpper(c) - 'A';
                int K = Char.ToUpper(key[keyIdx]) - 'A';
                int EP = (K - P + 26) % 26;
                char cipherChar = (char)(EP + 'A');
                if (Char.IsLower(c)) cipherChar = Char.ToLower(cipherChar);
                sb.Append(cipherChar);
                ++keyIdx;
                keyIdx %= key.Length;
            }
            return sb.ToString();
        }

        public static string Decrypt(string encryptedText, string key) {
            return Encrypt(encryptedText, key);
        }

        private static bool ValidChar(char c) => (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z');
        private static bool ValidText(string text) {
            foreach (char c in text) {
                if (!ValidChar(c))
                    return false;
            }
            return true;
        }
    }
}
