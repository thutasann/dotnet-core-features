using System.Security.Cryptography;
using System.Text;

namespace advanced_c_.src.Utils
{
    public static class EncryptionDecryption
    {
        private static readonly byte[] Key = Encoding.UTF8.GetBytes("0123456789ABCDEF");
        private static readonly byte[] IV = Encoding.UTF8.GetBytes("ABCDEF0123456789");

        public static void UsageSample()
        {
            Console.WriteLine("Encryption Decryption ==> ");

            string originalText = "Hello, World!";
            string encryptedText = Encrypt(originalText);
            string decryptedText = Decrypt(encryptedText);

            Console.WriteLine("Original: " + originalText);
            Console.WriteLine("Encrypted: " + encryptedText);
            Console.WriteLine("Decrypted: " + decryptedText);
        }

        public static string Encrypt(string plainText)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                        return Convert.ToBase64String(msEncrypt.ToArray());
                    }
                }
            }
        }

        public static string Decrypt(string cipherText)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(Convert.FromBase64String(cipherText)))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            return srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
        }
    }
}