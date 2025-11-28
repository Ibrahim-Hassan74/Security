using Security.Algorithms;
using Security.Models;
using Security.ServiceContract;
using System;

namespace Security.Service
{
    public class PolyalphabeticService : ICipherService
    {
        public string Id => "Vigenere";
        public string Name => "Polyalphabetic (Vigenère)";
        public bool RequiresKey => true;
        public string KeyHint => "letters";

        public string GenerateKey() => null;

        public EncryptionResult Encrypt(string plaintext, string key = null)
        {
            if (string.IsNullOrEmpty(key)) throw new ArgumentException("Vigenère requires a key.");
            var enc = PolyAlphabeticCipher.Encrypt(plaintext, key);
            return new EncryptionResult
            {
                AlgorithmId = Id,
                UsedKey = key.ToUpper(),
                Ciphertext = enc
            };
        }

        public string Decrypt(string ciphertext, string key)
        {
            return PolyAlphabeticCipher.Decrypt(ciphertext, key);
        }
    }
}
