using Security.Extensions;
using System;
using System.Text;

namespace Security.Algorithms
{
    public class AutoKeyCipher
    {
        public string Text { get; set; }
        public string Key { get; set; }

        static int ToNumber(char c) => c - 'A';

        public static string Encrypt(string text, string key)
        {
            if (text == null) throw new ArgumentNullException("text");
            if (string.IsNullOrEmpty(key)) throw new ArgumentException("key cannot be empty");

            text = text.ToUpper();
            key = key.ToUpper();

            var encryptedText = new StringBuilder();
            var autoKey = new StringBuilder(key);
            int idx = 0;

            foreach (char t in text)
            {
                if (!t.IsAsciiLetter())
                {
                    encryptedText.Append(t);
                    continue;
                }

                char c = (char)((ToNumber(t) + ToNumber(autoKey[idx])) % 26 + 'A');
                encryptedText.Append(c);
                autoKey.Append(t);
                idx++;
            }

            return encryptedText.ToString();
        }

        public static string Decrypt(string encryptedText, string key)
        {
            if (encryptedText == null) throw new ArgumentNullException("encryptedText");
            if (string.IsNullOrEmpty(key)) throw new ArgumentException("key cannot be empty");

            encryptedText = encryptedText.ToUpper();
            key = key.ToUpper();

            var decryptedText = new StringBuilder();
            var autoKey = new StringBuilder(key);
            int idx = 0;

            foreach (char c in encryptedText)
            {
                if (!c.IsAsciiLetter())
                {
                    decryptedText.Append(c);
                    continue;
                }

                char t = (char)((ToNumber(c) - ToNumber(autoKey[idx]) + 26) % 26 + 'A');
                decryptedText.Append(t);
                autoKey.Append(t);
                idx++;
            }

            return decryptedText.ToString();
        }
    }
}
