using Security.Algorithms;
using Security.Models;
using Security.ServiceContract;
using System;
using System.Collections.Generic;

namespace Security.Service
{
    public class PlayFairService : ICipherService
    {
        public string Id => "PlayFair";

        public string Name => "PlayFair Cipher (6x6)";

        public bool RequiresKey => true;

        public string KeyHint => "Use uppercase A–Z letters and numbers (no spaces)";
        public List<string> LastCloseWords { get; private set; } = new List<string>();

        public string GenerateKey() => null;

        public EncryptionResult Encrypt(string plaintext, string key = null)
        {
            if (string.IsNullOrWhiteSpace(plaintext))
                throw new ArgumentException("Plaintext cannot be empty.", nameof(plaintext));

            if (string.IsNullOrWhiteSpace(key))
                throw new ArgumentException("PlayFair cipher requires a key.", nameof(key));

            var cipherText = PlayFairCipher.Encrypt(plaintext, key);

            return new EncryptionResult
            {
                AlgorithmId = Id,
                Ciphertext = cipherText,
                UsedKey = key
            };
        }

        public string Decrypt(string ciphertext, string key)
        {
            if (string.IsNullOrWhiteSpace(ciphertext))
                throw new ArgumentException("Ciphertext cannot be empty.", nameof(ciphertext));

            if (string.IsNullOrWhiteSpace(key))
                throw new ArgumentException("PlayFair cipher requires a key.", nameof(key));

            var (plain, closeWords) = PlayFairCipher.Decrypt(ciphertext, key);
            LastCloseWords = closeWords ?? new List<string>();
            return plain;
        }
    }

}
