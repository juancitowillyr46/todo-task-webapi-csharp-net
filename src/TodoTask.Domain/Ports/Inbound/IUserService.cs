﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoTask.Domain.Models;

namespace TodoTask.Domain.Ports.Inbound
{
    public interface IUserService
    {
        UserModel GetUserByUsername(string username);
        UserModel CreateUser(UserModel userModel);
    }
}
