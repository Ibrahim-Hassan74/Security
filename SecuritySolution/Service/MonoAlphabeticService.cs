using Security.Algorithms;
using Security.Models;
using Security.ServiceContract;
using System;
using System.Text;

namespace Security.Service
{
    public class MonoAlphabeticService : ICipherService
    {
        public string Id => "Mono";
        public string Name => "Monoalphabetic Cipher";
        public bool RequiresKey => false;
        public string KeyHint => "52 letters (a..z A..Z)";

        public string GenerateKey()
        {
            var sb = new StringBuilder();
            for (char c = 'a'; c <= 'z'; ++c) sb.Append(c);
            for (char c = 'A'; c <= 'Z'; ++c) sb.Append(c);
            var arr = sb.ToString().ToCharArray();
            var rnd = new Random();
            for (int i = 0; i < arr.Length; ++i)
            {
                int j = rnd.Next(0, arr.Length);
                (arr[i], arr[j]) = (arr[j], arr[i]);
            }
            return new string(arr);
        }

        public EncryptionResult Encrypt(string plaintext, string key = null)
        {
            if (string.IsNullOrEmpty(key))
            {
                var mac = new MonoAlphabeticCipher(plaintext);

                return new EncryptionResult
                {
                    AlgorithmId = Id,
                    UsedKey = mac.Key,
                    Ciphertext = mac.Encrypt()
                };
            }
            else
            {
                var enc = MonoAlphabeticCipher.Encrypt(plaintext, key);
                return new EncryptionResult
                {
                    AlgorithmId = Id,
                    UsedKey = key,
                    Ciphertext = enc
                };
            }
        }

        public string Decrypt(string ciphertext, string key)
        {
            return MonoAlphabeticCipher.Decrypt(ciphertext, key);
        }
    }
}
