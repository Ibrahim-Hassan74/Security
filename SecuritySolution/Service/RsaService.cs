using Security.Algorithms;
using Security.Models;
using Security.ServiceContract;
using System;

namespace Security.Service
{
    public class RsaService : ICipherService
    {
        public string Id => "RSA";
        public string Name => "RSA (embedded key)";
        public bool RequiresKey => false;
        public string KeyHint => "No key required (uses embedded RSA key pair)";

        public string GenerateKey() => null;

        public EncryptionResult Encrypt(string plaintext, string key = null)
        {
            if (string.IsNullOrWhiteSpace(plaintext))
                throw new ArgumentException("Plaintext cannot be empty.", nameof(plaintext));

            string ciphertext;

            try
            {
                ciphertext = RSACipher.Encrypt(plaintext);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("RSA encryption failed.", ex);
            }

            return new EncryptionResult
            {
                AlgorithmId = Id,
                Ciphertext = ciphertext,
                UsedKey = null
            };
        }

        public string Decrypt(string ciphertext, string key)
        {
            if (string.IsNullOrWhiteSpace(ciphertext))
                throw new ArgumentException("Ciphertext cannot be empty.", nameof(ciphertext));

            string plain;
            try
            {
                plain = RSACipher.Decrypt(ciphertext);
            }
            catch (FormatException ex)
            {
                throw new ArgumentException("Ciphertext is not a valid Base64 string or has invalid format.", ex);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("RSA decryption failed.", ex);
            }

            return plain;
        }
    }
}
