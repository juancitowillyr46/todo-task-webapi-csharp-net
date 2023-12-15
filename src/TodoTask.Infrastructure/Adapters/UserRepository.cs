using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoTask.Domain.Models;
using TodoTask.Domain.Ports.Outbound;
using TodoTask.Infrastructure.Persistence.Database;
using TodoTask.Infrastructure.Persistence.Entities;

namespace TodoTask.Infrastructure.Adapters
{
    public class UserRepository : IUserRepository
    {
        private readonly TodoTaskDbContext _dbContext;
        private readonly IMapper _mapper;

        public UserRepository(TodoTaskDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public UserModel CreateUser(UserModel userModel)
        {
            UserEntity userEntity = _mapper.Map<UserEntity>(userModel);
            _dbContext.Users?.Add(userEntity);
            _dbContext.SaveChanges();
            return _mapper.Map<UserModel>(userEntity);
        }

        public UserModel GetUserByUsername(string username)
        {
            UserEntity? userEntity = _dbContext.Users?.Where(c => c.Email == username).FirstOrDefault();
            return _mapper.Map<UserModel>(userEntity);
        }
    }
}
