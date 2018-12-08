using System;
using System.Security.Cryptography;
using System.Text;

namespace Pong9.Helpers
{
    public class HashingAlg
    {
        public string HashPassword(string password)
        {
            using (var shaHelper = SHA256.Create())
            {
                var hashedBytes = shaHelper.ComputeHash(Encoding.UTF8.GetBytes(password));

                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }
    }
}
