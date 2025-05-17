using PasswordVault.Models;
using PasswordVault.Services;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace PasswordVault.Data
{
    public static class VaultStorage
    {
        private static readonly string FilePath = "vault.dat";

        public static void Save(List<PasswordEntry> entries, string password)
        {
            var json = JsonSerializer.Serialize(entries);
            var encrypted = EncryptionService.Encrypt(json, password);
            File.WriteAllBytes(FilePath, encrypted);
        }

        public static List<PasswordEntry> Load(string password)
        {
            if (!File.Exists(FilePath))
                return new List<PasswordEntry>();

            var encrypted = File.ReadAllBytes(FilePath);
            try
            {
                var json = EncryptionService.Decrypt(encrypted, password);
                return JsonSerializer.Deserialize<List<PasswordEntry>>(json) ?? new();
            }
            catch
            {
                return new List<PasswordEntry>();
            }
        }
    }
}
