namespace Security.Models
{
    public class EncryptionResult
    {
        public string Ciphertext { get; set; } = string.Empty;
        public string UsedKey { get; set; }
        public string AlgorithmId { get; set; } = string.Empty;
    }
}
