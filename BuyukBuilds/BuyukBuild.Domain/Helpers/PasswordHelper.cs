using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BuyukBuild.Domain.Helpers
{
    public class PasswordHelper
    {
        private const int KeySize = 32;
        private const int IterationsCount = 1000;

        public static string Encrypt(string password)
        {
            using (var result = new Rfc2898DeriveBytes(
                password: password,
                salt: Encoding.UTF8.GetBytes(password),
                iterations: IterationsCount,
                hashAlgorithm:HashAlgorithmName.SHA256)
                )
            {
                return Convert.ToBase64String(result.GetBytes(KeySize));
            }
        }


        public static bool Verify(string passwordHash, string password)
        {
            return Encrypt(password).SequenceEqual(passwordHash);
        }
    }
}
