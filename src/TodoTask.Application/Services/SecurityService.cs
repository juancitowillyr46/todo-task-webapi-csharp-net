using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoTask.Domain.Models;
using TodoTask.Domain.Ports.Inbound;
using TodoTask.Domain.Ports.Outbound;
using TodoTask.Infrastructure.Exceptions;

namespace TodoTask.Application.Services
{
    public class SecurityService : ISecurityService
    {
        private readonly IUserRepository _userRepository;
        private readonly IPasswordEncryptionService _passwordEncryptionService;
        private readonly IJwtService _jwtService;

        public SecurityService(IUserRepository userRepository, IPasswordEncryptionService passwordEncryptionService, IJwtService jwtService)
        {
            _userRepository = userRepository;
            _passwordEncryptionService = passwordEncryptionService;
            _jwtService = jwtService;
        }
        public string PostLogin(string username, string password)
        {
            UserModel userModel = _userRepository.GetUserByUsername(username) ?? throw new NotFoundException("Valid: User not exist");
            bool verifyPassword = _passwordEncryptionService.VerifyPassword(password, userModel.Password!);
            if(!verifyPassword)
            {
                throw new NotFoundException("Valid: Password Incorrect");
            }

            string jwtToken = _jwtService.GetJwt(userModel);
            return jwtToken;
        }

        public UserModel PostRegister(UserModel userModel)
        {
            if(_userRepository.GetUserByUsername(userModel.Username!) != null)
            {
                throw new NotFoundException("User exist");
            }
            string encryptPassword = _passwordEncryptionService.EncryptPassword(userModel.Password!);
            userModel.Password = encryptPassword;
            return _userRepository.CreateUser(userModel);
        }
    }
}
