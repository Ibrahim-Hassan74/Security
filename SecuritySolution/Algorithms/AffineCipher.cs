using System;
using System.Text;

namespace Security.Algorithms
{
    public static class AffineCipher
    {
        private static readonly int CHAR_SET_SIZE = 52;
        public static string Encrypt(string text, int a, int b)
        {
            if (String.IsNullOrEmpty(text)) throw new ArgumentNullException("text");
            if (!ValidText(text))
                throw new ArgumentException("text must contain only lower and upper case english letters");
            ModInverse(a);
            var encryptedText = new StringBuilder();
            foreach (char t in text)
            {
                int k = (a * ToNumber(t) % CHAR_SET_SIZE + b % CHAR_SET_SIZE + CHAR_SET_SIZE) % CHAR_SET_SIZE;
                encryptedText.Append(ToChar(k));
            }
            return encryptedText.ToString();
        }

        public static string Decrypt(string text, int a, int b)
        {
            if (String.IsNullOrEmpty(text)) throw new ArgumentNullException("text");
            if (!ValidText(text))
                throw new ArgumentException("text must contain only lower and upper case english letters");
            a = ModInverse(a);
            var decryptedText = new StringBuilder();
            foreach (char c in text)
            {
                int k = (a * (ToNumber(c) % CHAR_SET_SIZE - b % CHAR_SET_SIZE + CHAR_SET_SIZE)) % CHAR_SET_SIZE;
                decryptedText.Append(ToChar(k));
            }
            return decryptedText.ToString();
        }

        private static int ToNumber(char c)
        {
            if (Char.IsLower(c))
                return c - 'a';
            return c - 'A' + 26;
        }
        private static char ToChar(int n)
        {
            if (n < 0 || n >= CHAR_SET_SIZE)
                throw new ArgumentOutOfRangeException("n");
            if (n < 26)
                return (char)(n + 'a');
            return (char)(n - 26 + 'A');
        }
        private static bool ValidText(string text)
        {
            foreach (char c in text)
            {
                if (!(Char.IsUpper(c) || Char.IsLower(c)))
                    return false;
            }
            return true;
        }
        private static int ModInverse(int a)
        {
            a = (a % CHAR_SET_SIZE + CHAR_SET_SIZE) % CHAR_SET_SIZE;
            for (int i = 1; i < CHAR_SET_SIZE; i++)
            {
                if ((a * i) % CHAR_SET_SIZE == 1)
                    return i;
            }
            throw new ArgumentException("No modular inverse exists.");
        }
    }
}
