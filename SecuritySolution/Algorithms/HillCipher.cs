using System;
using System.Collections.Generic;
using System.Text;

namespace Security.Algorithms
{
    public static class HillCipher
    {
        private static char Filler = '-';
        private static readonly int MATRIX_SIZE = 2;
        private static readonly int CHAR_SET_SIZE = 27;

        public static string Encrypt(string text, List<int> matrix_values)
        {
            if (String.IsNullOrEmpty(text)) throw new ArgumentNullException("text");
            if (!ValidText(text))
                throw new ArgumentException("text must contain only upper case english letters");
            int[,] matrix = {
                { matrix_values[0], matrix_values[1] },
                { matrix_values[2], matrix_values[3] }
            };
            int[,] matrixInverse = MatrixInverse(matrix);

            if (text.Length % 2 != 0)
            {
                text += Filler;
            }

            var encryptedText = new StringBuilder();
            for (int i = 0; i < text.Length; i += 2)
            {
                int t1 = text[i] - 'A';
                int t2 = text[i + 1] == Filler ? 26 : text[i + 1] - 'A';
                int[] v = { t1, t2 };
                int[] encryptedVector = MatrixMultiply(matrix, v);
                var (c1, c2) = GetPair(encryptedVector);
                encryptedText.Append(c1);
                encryptedText.Append(c2);
            }
            return encryptedText.ToString();
        }

        public static string Decrypt(string text, List<int> matrix_values)
        {
            if (String.IsNullOrEmpty(text)) throw new ArgumentNullException("text");
            if (!ValidText(text))
                throw new ArgumentException("text must contain only upper case english letters");
            if (text.Length % 2 != 0)
                throw new ArgumentException("the text must be of even length");
            int[,] matrix = {
                { matrix_values[0], matrix_values[1] },
                { matrix_values[2], matrix_values[3] }
            };
            int[,] matrixInverse = MatrixInverse(matrix);

            var decryptedText = new StringBuilder();
            for (int i = 0; i < text.Length; i += 2)
            {
                int c1 = text[i] - 'A';
                int c2 = text[i + 1] == Filler ? 26 : text[i + 1] - 'A';
                int[] v = { c1, c2 };
                int[] decryptedVector = MatrixMultiply(matrixInverse, v);
                var (t1, t2) = GetPair(decryptedVector);
                decryptedText.Append(t1);
                if (t2 != Filler)
                    decryptedText.Append(t2);
            }
            return decryptedText.ToString();
        }

        private static bool ValidText(string text)
        {
            foreach (char c in text)
            {
                if (!Char.IsUpper(c))
                    return false;
            }
            return true;
        }
        private static (char, char) GetPair(int[] v)
        {
            return ((char)(v[0] + 'A'), v[1] == 26 ? Filler : (char)(v[1] + 'A'));
        }
        public static int ModInverse(int a)
        {
            a = (a % CHAR_SET_SIZE + CHAR_SET_SIZE) % CHAR_SET_SIZE;
            for (int x = 1; x < CHAR_SET_SIZE; x++)
                if ((a * x) % CHAR_SET_SIZE == 1)
                    return x;
            throw new Exception("No modular inverse exists.");
        }
        public static int Determinant(int[,] m)
        {
            return (m[0, 0] * m[1, 1] - m[0, 1] * m[1, 0]) % CHAR_SET_SIZE;
        }
        public static int[,] MatrixInverse(int[,] m)
        {
            int det = Determinant(m);
            int detInv = ModInverse(det);

            int[,] adj = {
                {  m[1,1], -m[0,1] },
                { -m[1,0],  m[0,0] }
            };

            int[,] inv = new int[2, 2];

            for (int i = 0; i < MATRIX_SIZE; i++)
                for (int j = 0; j < MATRIX_SIZE; j++)
                    inv[i, j] = ((adj[i, j] * detInv) % CHAR_SET_SIZE + CHAR_SET_SIZE) % CHAR_SET_SIZE;

            return inv;
        }
        public static int[] MatrixMultiply(int[,] m, int[] v)
        {
            return new int[] {
                (m[0,0] * v[0] + m[0,1] * v[1]) % CHAR_SET_SIZE,
                (m[1,0] * v[0] + m[1,1] * v[1]) % CHAR_SET_SIZE
            };
        }
    }
}
