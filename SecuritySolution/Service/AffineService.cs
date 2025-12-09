using Security.Algorithms;
using Security.Extensions;
using Security.Models;
using Security.ServiceContract;
using System;
using System.Linq;

namespace Security.Service
{
    public class AffineService : ICipherService
    {
        public string Id => "Affine";
        public string Name => "Affine Cipher";
        public bool RequiresKey => true;
        public string KeyHint => "Two integers separated by comma (a,b). 'a' must be coprime with 52.";

        public string GenerateKey()
        {
            var rnd = new Random();
            // generate a until gcd(a,52)==1
            int a;
            for (int tries = 0; tries < 10000; ++tries)
            {
                a = rnd.Next(1, 52); // 1..51
                if (MathX.Gcd(a, 52) == 1)
                {
                    int b = rnd.Next(0, 52); // 0..51
                    return $"{a},{b}";
                }
            }
            return null;
        }

        public EncryptionResult Encrypt(string plaintext, string key = null)
        {
            if (string.IsNullOrWhiteSpace(plaintext))
                throw new ArgumentException("Plaintext cannot be empty.", nameof(plaintext));

            if (string.IsNullOrWhiteSpace(key))
                throw new ArgumentException("Affine cipher requires a key.", nameof(key));

            var (a, b) = ParseKey(key);

            var ciphertext = AffineCipher.Encrypt(plaintext, a, b);

            return new EncryptionResult
            {
                AlgorithmId = Id,
                Ciphertext = ciphertext,
                UsedKey = $"{a},{b}"
            };
        }

        public string Decrypt(string ciphertext, string key)
        {
            if (string.IsNullOrWhiteSpace(ciphertext))
                throw new ArgumentException("Ciphertext cannot be empty.", nameof(ciphertext));

            if (string.IsNullOrWhiteSpace(key))
                throw new ArgumentException("Affine cipher requires a key.", nameof(key));

            var (a, b) = ParseKey(key);

            var plain = AffineCipher.Decrypt(ciphertext, a, b);
            return plain;
        }

        private static (int a, int b) ParseKey(string key)
        {
            var parts = key.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                           .Select(p => p.Trim())
                           .ToArray();

            if (parts.Length != 2)
                throw new ArgumentException("Affine key must contain exactly 2 integers separated by a comma (a,b).");

            if (!int.TryParse(parts[0], out int a))
                throw new ArgumentException("First part of key (a) must be an integer.");
            if (!int.TryParse(parts[1], out int b))
                throw new ArgumentException("Second part of key (b) must be an integer.");

            a = ((a % 52) + 52) % 52;
            b = ((b % 52) + 52) % 52;

            if (MathX.Gcd(a, 52) != 1)
                throw new ArgumentException("Value 'a' is not invertible modulo 52. Choose 'a' coprime with 52 (not divisible by 2 or 13).");

            return (a, b);
        }
    }
}
