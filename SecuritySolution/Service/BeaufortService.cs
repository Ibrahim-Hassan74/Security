using Security.Algorithms;
using Security.Models;
using Security.ServiceContract;
using System;

namespace Security.Service
{
    public class BeaufortService : ICipherService
    {
        public string Id => "Beaufort";

        public string Name => "Beaufort Cipher";

        public bool RequiresKey => true;

        public string KeyHint => "Use only alphabet letters (A–Z / a–z)";

        public string GenerateKey() => null;

        public EncryptionResult Encrypt(string plaintext, string key = null)
        {
            if (string.IsNullOrWhiteSpace(plaintext))
                throw new ArgumentException("Plaintext cannot be empty.", nameof(plaintext));

            if (string.IsNullOrWhiteSpace(key))
                throw new ArgumentException("Beaufort cipher requires a key.", nameof(key));

            if (!IsValidKey(key))
                throw new ArgumentException("Key must contain only alphabet letters (A–Z / a–z).");

            var ciphertext = BeauforCipher.Encrypt(plaintext, key);

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
                throw new ArgumentException("Beaufort cipher requires a key.");

            if (!IsValidKey(key))
                throw new ArgumentException("Key must contain only alphabet letters (A–Z / a–z).");

            return BeauforCipher.Decrypt(ciphertext, key);
        }

        private bool IsValidKey(string key)
        {
            foreach (char c in key)
                if (!char.IsLetter(c))
                    return false;
            return true;
        }
    }
}
