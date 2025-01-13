using System;
using System.Security.Cryptography;
using System.Text;

namespace Lecture_28_FinancialCrm.Helpers
{
    public static class HashHelper
    {
        // Şifreyi SHA256 ile hash'ler
        public static string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Şifreyi byte dizisine çevirip hash'liyoruz
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (var t in bytes)
                {
                    builder.Append(t.ToString("x2")); // Hashlenmiş byte'ları hexadecimal (16'lık) formata çeviriyoruz
                }
                return builder.ToString(); // Hashlenmiş şifreyi döndürüyoruz
            }
        }
    }
}
