public class Program
{
    public static void Main()
    {
        string encryptionKey = EncryptionKeyGenerator.EncryptionKeyGenerator.GenerateEncryptionKey();
        Console.WriteLine($"Generated encryption key: {encryptionKey}");
    }
}