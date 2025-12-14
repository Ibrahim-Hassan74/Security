using Security.Algorithms;
using Security.Models;
using Security.ServiceContract;
using System;

namespace Security.Service
{
    public class AutoKeyService : ICipherService
    {
        public string Id => "AutoKey";
        public string Name => "Auto-Key Cipher";
        public bool RequiresKey => true;

        public string KeyHint => "Use alphabet letters only (A–Z / a–z). Example: KEY";

        public string GenerateKey() => null;

        public EncryptionResult Encrypt(string plaintext, string key = null)
        {
            if (string.IsNullOrWhiteSpace(plaintext))
                throw new ArgumentException("Plaintext cannot be empty.", nameof(plaintext));

            if (string.IsNullOrWhiteSpace(key))
                throw new ArgumentException("Auto-Key cipher requires a key.", nameof(key));

            if (!IsValidKey(key))
                throw new ArgumentException("Key must contain only letters A–Z or a–z.");

            string cipher;
            try
            {
                cipher = AutoKeyCipher.Encrypt(plaintext, key);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Auto-Key encryption failed.", ex);
            }

            return new EncryptionResult
            {
                AlgorithmId = Id,
                Ciphertext = cipher,
                UsedKey = key
            };
        }

        public string Decrypt(string ciphertext, string key)
        {
            if (string.IsNullOrWhiteSpace(ciphertext))
                throw new ArgumentException("Ciphertext cannot be empty.", nameof(ciphertext));

            if (string.IsNullOrWhiteSpace(key))
                throw new ArgumentException("Auto-Key cipher requires a key.", nameof(key));

            if (!IsValidKey(key))
                throw new ArgumentException("Key must contain only letters A–Z or a–z.");

            string plain;
            try
            {
                plain = AutoKeyCipher.Decrypt(ciphertext, key);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Auto-Key decryption failed.", ex);
            }

            return plain;
        }

        private bool IsValidKey(string key)
        {
            foreach (char c in key)
            {
                if (!char.IsLetter(c))
                    return false;
            }
            return true;
        }
    }
}
