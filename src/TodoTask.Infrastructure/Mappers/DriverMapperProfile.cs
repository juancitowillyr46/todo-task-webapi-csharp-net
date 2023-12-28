using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoTask.Application.Dtos.Device;
using TodoTask.Application.Dtos.Driver;
using TodoTask.Domain.Models;
using TodoTask.Infrastructure.Database.Persitence.Entities;

namespace TodoTask.Infrastructure.Mappers
{
    public class DriverMapperProfile : Profile
    {
        public DriverMapperProfile()
        {
            CreateMap<DriverEntity, DriverModel>();
            CreateMap<DriverModel, GetDriverDto>();
        }
    }
}
