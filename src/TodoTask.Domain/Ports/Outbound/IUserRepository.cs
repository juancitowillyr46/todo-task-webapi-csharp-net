using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoTask.Domain.Models;

namespace TodoTask.Domain.Ports.Outbound
{
    public interface IUserRepository
    {
        UserModel GetUserByUsername(string username);

        UserModel CreateUser(UserModel userModel);
    }
}
