using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoTask.Domain.Ports.Inbound
{
    public interface IPasswordEncryptionService
    {
        string EncryptPassword(string password);
        bool VerifyPassword(string inputPassword, string storedPassword);
    }
}
