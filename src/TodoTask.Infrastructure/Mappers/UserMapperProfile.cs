using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoTask.Application.Dtos.User;
using TodoTask.Domain.Models;
using TodoTask.Infrastructure.Database.Persitence.Entities;

namespace TodoTask.Infrastructure.Mappers
{
    public class UserMapperProfile : Profile
    {
        public UserMapperProfile() {
            CreateMap<UserEntity, UserModel>();
            CreateMap<UserModel, UserEntity>();
            CreateMap<UserRegisterDto, UserModel>();
            CreateMap<UserModel, GetRegisterUserDto>();
        }
    }
}
