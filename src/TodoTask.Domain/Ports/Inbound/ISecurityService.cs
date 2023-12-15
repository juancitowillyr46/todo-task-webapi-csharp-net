using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoTask.Domain.Models;

namespace TodoTask.Domain.Ports.Inbound
{
    public interface ISecurityService
    {
        string PostLogin(string username, string password);
        UserModel PostRegister(UserModel userModel);
    }
}
