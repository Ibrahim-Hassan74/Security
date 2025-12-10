using Security.Extensions;
using System;
using System.Text;

namespace Security.Algorithms
{
    public class PolyAlphabeticCipher {
        public string Text { get; set; }
        public string Key { get; set; }

        static int ToNumber(char c) => c - 'A';

        public static string Encrypt(string text, string key) {
            if (text == null) throw new ArgumentNullException("text");
            if (string.IsNullOrEmpty(key)) throw new ArgumentException("key cannot be empty");
            text = text.ToUpper();
            key = key.ToUpper();
            var encryptedText = new StringBuilder();
            int idx = 0;
            foreach (char t in text) {
                if (!t.IsAsciiLetter()) {
                    encryptedText.Append(t);
                    continue;
                }
                char c = (char)((ToNumber(t) + ToNumber(key[idx++])) % 26 + 'A');
                idx %= key.Length;
                encryptedText.Append(c);
            }
            return encryptedText.ToString();
        }

        public static string Decrypt(string encryptedText, string key) {
            if (encryptedText == null) throw new ArgumentNullException("encryptedText");
            if (string.IsNullOrEmpty(key)) throw new ArgumentException("key cannot be empty");
            key = key.ToUpper();
            var decryptedText = new StringBuilder();
            int idx = 0;
            foreach (char c in encryptedText) {
                if (!c.IsAsciiLetter()) {
                    decryptedText.Append(c);
                    continue;
                }
                char t = (char)((ToNumber(c) - ToNumber(key[idx++]) + 26) % 26 + 'A');
                idx %= key.Length;
                decryptedText.Append(t);
            }
            return decryptedText.ToString();
        }
    }
}
