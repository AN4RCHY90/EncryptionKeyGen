using System.Security.Cryptography;

namespace EncryptionKeyGenerator;

public static class EncryptionKeyGenerator
{
    public static string GenerateEncryptionKey(int keySize = 256)
    {
        byte[] key = new byte[keySize / 8];
        RandomNumberGenerator.Fill(key);
        return Convert.ToBase64String(key);
    }
}