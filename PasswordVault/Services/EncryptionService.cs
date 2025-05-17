using System.Security.Cryptography;
using System.Text;

namespace PasswordVault.Services
{
    public static class EncryptionService
    {
        public static byte[] Encrypt(string plainText, string password)
        {
            using var aes = Aes.Create();
            var key = GetKey(password);
            aes.Key = key;
            aes.GenerateIV();

            using var encryptor = aes.CreateEncryptor();
            var plainBytes = Encoding.UTF8.GetBytes(plainText);
            var encrypted = encryptor.TransformFinalBlock(plainBytes, 0, plainBytes.Length);

            var result = new byte[aes.IV.Length + encrypted.Length];
            Buffer.BlockCopy(aes.IV, 0, result, 0, aes.IV.Length);
            Buffer.BlockCopy(encrypted, 0, result, aes.IV.Length, encrypted.Length);
            return result;
        }

        public static string Decrypt(byte[] encryptedData, string password)
        {
            using var aes = Aes.Create();
            var key = GetKey(password);
            aes.Key = key;

            var iv = new byte[aes.BlockSize / 8];
            var cipher = new byte[encryptedData.Length - iv.Length];

            Buffer.BlockCopy(encryptedData, 0, iv, 0, iv.Length);
            Buffer.BlockCopy(encryptedData, iv.Length, cipher, 0, cipher.Length);

            aes.IV = iv;
            using var decryptor = aes.CreateDecryptor();
            var decrypted = decryptor.TransformFinalBlock(cipher, 0, cipher.Length);
            return Encoding.UTF8.GetString(decrypted);
        }

        private static byte[] GetKey(string password)
        {
            using var sha = SHA256.Create();
            return sha.ComputeHash(Encoding.UTF8.GetBytes(password));
        }
    }
}
