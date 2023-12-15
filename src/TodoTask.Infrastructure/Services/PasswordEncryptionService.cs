using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TodoTask.Domain.Ports.Inbound;

namespace TodoTask.Infrastructure.Services
{
    public class PasswordEncryptionService : IPasswordEncryptionService
    {
        public string EncryptPassword(string password)
        {
            using var sha256 = SHA256.Create();
            byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(hashedBytes);
        }

        public bool VerifyPassword(string inputPassword, string storedPassword)
        {
            string hashedInputPassword = EncryptPassword(inputPassword);
            return hashedInputPassword == storedPassword;
        }
    }
}
