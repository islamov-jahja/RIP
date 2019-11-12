using System;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Text;

namespace RipBackend.Services.Helpers
{
    public class Privacy
    {
        public static string GetHashedPassword(string password)
        {
            var sha1 = SHA1.Create();
            var step1 = Encoding.UTF8.GetBytes(password);
            var step2 = sha1.ComputeHash(step1);
            var step3 = Convert.ToBase64String(step2);

            return step3;
        }
    }
}
