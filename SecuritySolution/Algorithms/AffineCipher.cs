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
            if (!HasModInv(Normalize(a)))
                throw new ArgumentException("No modular inverse exists.");
            
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
            if (c >= 'a' && c <= 'z')
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
        private static bool ValidChar(char c) => (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z');
        private static bool ValidText(string text)
        {
            foreach (char c in text)
            {
                if (!ValidChar(c))
                    return false;
            }
            return true;
        }
        private static int ModInverse(int a) {
            a = Normalize(a);
            if (!HasModInv(a))
                throw new ArgumentException("No modular inverse exists.");
            for (int i = 1; i < CHAR_SET_SIZE; i++)
            {
                if ((a * i) % CHAR_SET_SIZE == 1)
                    return i;
            }
            throw new ArgumentException("No modular inverse exists.");
        }

        private static bool HasModInv(int a) => Gcd(a, CHAR_SET_SIZE) == 1;
        private static int Gcd(int a, int b) => b != 0 ? Gcd(b, a % b) : a;
        private static int Normalize(int n) => (n % CHAR_SET_SIZE + CHAR_SET_SIZE) % CHAR_SET_SIZE;
    }
}
