using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoTask.Application.Dtos.Request;
using TodoTask.Domain.Models;
using TodoTask.Infrastructure.Database.Persitence.Entities;

namespace TodoTask.Infrastructure.Mappers
{
    public class RequestMapperProfile : Profile
    {
        public RequestMapperProfile() 
        {
            CreateMap<CreateRequestDto, RequestModel>();
            CreateMap<GetRequestDto, RequestModel>();
            CreateMap<RequestModel, RequestEntity>();
            CreateMap<RequestModel, GetRequestDto>();
            CreateMap<RequestEntity, RequestModel>();
            CreateMap<UpdateRequestDto, RequestModel>();
        }
    }
}
