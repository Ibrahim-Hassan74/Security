using Security.Algorithms;
using Security.Models;
using Security.ServiceContract;
using System;

namespace Security.Service
{
    public class CaesarService : ICipherService
    {
        public string Id => "Caesar";
        public string Name => "Caesar Cipher";
        public bool RequiresKey => true;
        public string KeyHint => "integer (shift)";

        public string GenerateKey() => null;

        public EncryptionResult Encrypt(string plaintext, string key = null)
        {
            if (string.IsNullOrEmpty(key)) throw new ArgumentException("Caesar requires a numeric key.");
            if (!long.TryParse(key, out var k)) throw new ArgumentException("Invalid Caesar key (integer expected).");
            var cc = new CaesarCipher(plaintext, k);
            return new EncryptionResult
            {
                AlgorithmId = Id,
                UsedKey = (k % 26).ToString(),
                Ciphertext = cc.Encrypt()
            };
        }

        public string Decrypt(string ciphertext, string key)
        {
            if (!long.TryParse(key, out var k)) throw new ArgumentException("Invalid Caesar key (integer expected).");
            return CaesarCipher.Decrypt(ciphertext, k);
        }
    }
}
