using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TodoTask.Application.Dtos.Vehicle;
using TodoTask.Domain.Models;
using TodoTask.Infrastructure.Database.Persitence.Entities;

namespace TodoTask.Infrastructure.Mappers
{
    public class VehicleMapperProfile : Profile
    {
        public VehicleMapperProfile()
        {
            CreateMap<VehicleEntity, VehicleModel>().ForMember(dest => dest.Device, opt => opt.MapFrom(src => src.Device));
            CreateMap<VehicleModel, GetVehicleDto>().ForMember(dest => dest.Device, opt => opt.MapFrom(src => src.Device));
        }
    }
}
