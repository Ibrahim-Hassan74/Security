using Security.Extensions;
using System;
using System.Text;

namespace Security.Algorithms
{
    public class PolyAlphabeticCipher
    {
        public string Text { get; set; }
        public string Key { get; set; }
        public PolyAlphabeticCipher(string text)
        {
            if (text == null) throw new ArgumentNullException("text");
            Text = text.ToUpper();
            var rnd = new Random();
            var key = new StringBuilder();
            for (int i = 0; i < text.Length; ++i)
            {
                char c = (char)('A' + rnd.Next(0, 26));
                key.Append(c);
            }
            Key = key.ToString();
        }

        public PolyAlphabeticCipher(string text, string key)
        {
            if (text == null) throw new ArgumentNullException("text");
            if (String.IsNullOrEmpty(key)) throw new ArgumentException("key cannot be empty");
            Text = text.ToUpper();
            Key = key.ToUpper();
        }

        static int ToNumber(char c) => c - 'A';

        public string Encrypt()
        {
            var encryptedText = new StringBuilder();
            int idx = 0;
            foreach (char t in Text)
            {
                if (!t.IsAsciiLetter())
                {
                    encryptedText.Append(t);
                    continue;
                }
                char c = (char)((ToNumber(t) + ToNumber(Key[idx++])) % 26 + 'A');
                idx %= Key.Length;
                encryptedText.Append(c);
            }
            return encryptedText.ToString();
        }

        public static string Encrypt(string text, string key)
        {
            if (text == null) throw new ArgumentNullException("text");
            if (string.IsNullOrEmpty(key)) throw new ArgumentException("key cannot be empty");
            var encryptedText = new StringBuilder();
            int idx = 0;
            foreach (char t in text)
            {
                if (!t.IsAsciiLetter())
                {
                    encryptedText.Append(t);
                    continue;
                }
                char c = (char)((ToNumber(t) + ToNumber(key[idx++])) % 26 + 'A');
                idx %= key.Length;
                encryptedText.Append(c);
            }
            return encryptedText.ToString();
        }

        public static string Decrypt(string encryptedText, string key)
        {
            if (encryptedText == null) throw new ArgumentNullException("encryptedText");
            if (string.IsNullOrEmpty(key)) throw new ArgumentException("key cannot be empty");
            var decryptedText = new StringBuilder();
            int idx = 0;
            foreach (char c in encryptedText)
            {
                if (!c.IsAsciiLetter())
                {
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
