using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoTask.Domain.Models;
using TodoTask.Domain.Ports.Inbound;
using TodoTask.Domain.Ports.Outbound;

namespace TodoTask.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IPasswordEncryptionService _passwordEncryptionService;

        public UserService(IUserRepository userRepository, IPasswordEncryptionService passwordEncryptionService)
        {
            _userRepository = userRepository;
            _passwordEncryptionService = passwordEncryptionService;
        }

        public UserModel CreateUser(UserModel userModel)
        {
            string encryptPassword = _passwordEncryptionService.EncryptPassword(userModel.Password!);
            userModel.Password = encryptPassword;
            return _userRepository.CreateUser(userModel);
        }

        public UserModel GetUserByUsername(string username)
        {
            return _userRepository.GetUserByUsername(username);
        }

    }
}
