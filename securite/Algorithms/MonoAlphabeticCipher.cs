using Security.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Security.Algorithms
{
    public class MonoAlphabeticCipher
    {
        public string Text { get; set; }

        public string Key { get; set; }
        public Dictionary<char, char> dict;

        public MonoAlphabeticCipher(string text)
        {
            if (text == null) throw new ArgumentNullException("text");
            Text = text;
            var key = new StringBuilder();
            for (char c = 'a'; c <= 'z'; ++c)
                key.Append(c);
            for (char c = 'A'; c <= 'Z'; ++c)
                key.Append(c);
            var rnd = new Random();
            for (int i = 0; i < key.Length; ++i)
            {
                int j = rnd.Next(0, key.Length);
                (key[i], key[j]) = (key[j], key[i]);
            }
            dict = new Dictionary<char, char>();
            int idx = 0;
            for (char c = 'a'; c <= 'z'; ++c)
                dict.Add(c, key[idx++]);
            for (char c = 'A'; c <= 'Z'; ++c)
                dict.Add(c, key[idx++]);
            Key = key.ToString();
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
                encryptedText.Append(dict[t]);
            }
            return encryptedText.ToString();
        }

        public static string Encrypt(string text, string key)
        {
            if (text == null) throw new ArgumentNullException("text");
            if (key == null) throw new ArgumentNullException("key");

            if (!ValidKey(key))
                throw new Exception("invalid key");
            var d = new Dictionary<char, char>();
            int idx = 0;
            for (char c = 'a'; c <= 'z'; ++c)
                d.Add(c, key[idx++]);
            for (char c = 'A'; c <= 'Z'; ++c)
                d.Add(c, key[idx++]);
            var encryptedText = new StringBuilder();
            foreach (char t in text)
            {
                if (!t.IsAsciiLetter())
                {
                    encryptedText.Append(t);
                    continue;
                }
                encryptedText.Append(d[t]);
            }
            return encryptedText.ToString();
        }

        public static string Decrypt(string encryptedText, string key)
        {
            if (encryptedText == null) throw new ArgumentNullException("encryptedText");
            if (key == null) throw new ArgumentNullException("key");
            if (!ValidKey(key))
                throw new Exception("invalid key");
            var d = new Dictionary<char, char>();
            int idx = 0;
            for (char c = 'a'; c <= 'z'; ++c)
                d.Add(key[idx++], c);
            for (char c = 'A'; c <= 'Z'; ++c)
                d.Add(key[idx++], c);
            var decryptedText = new StringBuilder();
            foreach (char c in encryptedText)
            {
                if (!c.IsAsciiLetter())
                {
                    decryptedText.Append(c);
                    continue;
                }
                decryptedText.Append(d[c]);
            }
            return decryptedText.ToString();
        }

        static bool ValidKey(string key)
        {
            if (key.Length != 52) return false;
            var st = new HashSet<char>();
            foreach (char ch in key)
                st.Add(ch);
            for (char c = 'a'; c <= 'z'; ++c)
                if (!st.Contains(c)) return false;
            for (char c = 'A'; c <= 'Z'; ++c)
                if (!st.Contains(c)) return false;
            foreach (char c in key)
                if (!c.IsAsciiLetter()) return false;
            return true;
        }
    }
}
