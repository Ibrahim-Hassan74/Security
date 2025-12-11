using Security.Algorithms;
using Security.Models;
using Security.ServiceContract;
using System;
using System.Linq;
using System.Security.Cryptography;

namespace Security.Service
{
    public class MonoAlphabeticService : ICipherService
    {
        public string Id => "MonoAlphabetic";
        public string Name => "Monoalphabetic Substitution Cipher";
        public bool RequiresKey => true;
        public string KeyHint => "52 characters: a..z followed by A..Z in some permutation (e.g. \"qwerty...QWERTY...\")";

        public string GenerateKey()
        {
            var pool = Enumerable.Range('a', 26).Select(i => (char)i)
                       .Concat(Enumerable.Range('A', 26).Select(i => (char)i))
                       .ToArray();

            using (var rng = RandomNumberGenerator.Create())
            {
                for (int i = pool.Length - 1; i > 0; i--)
                {
                    byte[] b = new byte[4];
                    rng.GetBytes(b);
                    int r = (int) BitConverter.ToUInt32(b, 0) % (i + 1);
                    var tmp = pool[r];
                    pool[r] = pool[i];
                    pool[i] = tmp;
                }
            }

            return new string(pool);
        }

        public EncryptionResult Encrypt(string plaintext, string key = null)
        {
            if (string.IsNullOrWhiteSpace(plaintext))
                throw new ArgumentException("Plaintext cannot be empty.", nameof(plaintext));

            if (string.IsNullOrWhiteSpace(key))
                throw new ArgumentException("Monoalphabetic cipher requires a key.", nameof(key));

            if (!MonoAlphabeticCipher.ValidKey(key))
                throw new ArgumentException("Invalid key. Key must be 52 characters long and contain every letter a..z and A..Z exactly once.");

            string ciphertext;
            try
            {
                ciphertext = MonoAlphabeticCipher.Encrypt(plaintext, key);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Monoalphabetic encryption failed.", ex);
            }

            return new EncryptionResult
            {
                AlgorithmId = Id,
                Ciphertext = ciphertext,
                UsedKey = key
            };
        }

        public string Decrypt(string ciphertext, string key)
        {
            if (string.IsNullOrWhiteSpace(ciphertext))
                throw new ArgumentException("Ciphertext cannot be empty.", nameof(ciphertext));

            if (string.IsNullOrWhiteSpace(key))
                throw new ArgumentException("Monoalphabetic cipher requires a key.", nameof(key));

            if (!MonoAlphabeticCipher.ValidKey(key))
                throw new ArgumentException("Invalid key. Key must be 52 characters long and contain every letter a..z and A..Z exactly once.");

            string plain;
            try
            {
                plain = MonoAlphabeticCipher.Decrypt(ciphertext, key);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Monoalphabetic decryption failed.", ex);
            }

            return plain;
        }
    }
}
