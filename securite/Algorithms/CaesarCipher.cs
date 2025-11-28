using System;
using System.Collections.Generic;
using System.Text;
using Security.Extensions;

namespace Security.Algorithms
{
    public class CaesarCipher
    {
        public string Text { get; set; } = String.Empty;
        public long Key;
        public CaesarCipher(long key)
        {
            Key = key % 26;
        }
        public CaesarCipher(string text, long key)
        {
            if (text == null) throw new ArgumentNullException("text");
            if (key < 1) throw new ArgumentOutOfRangeException("key should be a positive integer");
            Text = text;
            Key = key % 26;
        }
        public string Encrypt()
        {
            var encryptedText = new StringBuilder();
            foreach (char t in Text)
            {
                if (!t.IsAsciiLetter())
                {
                    encryptedText.Append(t);
                    continue;
                }
                char offset = Char.IsUpper(t) ? 'A' : 'a';
                char c = (char)((t - offset + Key) % 26 + offset);
                encryptedText.Append(c);
            }
            return encryptedText.ToString();
        }

        public static string Encrypt(string text, int key)
        {
            if (text == null) throw new ArgumentNullException("text");
            if (key < 1) throw new ArgumentOutOfRangeException("key should be a positive integer");
            key %= 26;
            var encryptedText = new StringBuilder();
            foreach (char t in text)
            {
                if (!t.IsAsciiLetter())
                {
                    encryptedText.Append(t);
                    continue;
                }
                char offset = Char.IsUpper(t) ? 'A' : 'a';
                char c = (char)((t - offset + key) % 26 + offset);
                encryptedText.Append(c);
            }
            return encryptedText.ToString();
        }

        public static string Decrypt(string encryptedText, long key)
        {
            if (encryptedText == null) throw new ArgumentNullException("encryptedText");
            if (key < 1) throw new ArgumentOutOfRangeException("key should be a positive integer");
            key %= 26;
            var decryptedText = new StringBuilder();
            foreach (char c in encryptedText)
            {
                if (!c.IsAsciiLetter())
                {
                    decryptedText.Append(c);
                    continue;
                }
                char offset = Char.IsUpper(c) ? 'A' : 'a';
                char t = (char)((c - offset - key + 26) % 26 + offset);
                decryptedText.Append(t);
            }
            return decryptedText.ToString();
        }

        public static List<string> Decrypt(string encryptedText)
        {
            if (encryptedText == null) throw new ArgumentNullException("encryptedText");
            var list = new List<string>();
            for (int key = 1; key <= 25; ++key)
                list.Add(Decrypt(encryptedText, key));
            return list;
        }
    }
}
