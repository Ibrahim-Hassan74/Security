using Security.Models;

namespace Security.ServiceContract
{
    public interface ICipherService
    {
        string Id { get; }

        string Name { get; }

        bool RequiresKey { get; }

        string KeyHint { get; }

        string GenerateKey();

        EncryptionResult Encrypt(string plaintext, string key = null);

        string Decrypt(string ciphertext, string key);
    }
}
