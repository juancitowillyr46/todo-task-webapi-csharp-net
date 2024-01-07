using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using TodoTask.Application.Dtos.Request;
using TodoTask.Domain.Enums;
using TodoTask.Domain.Models;
using TodoTask.Infrastructure.Database.Persitence.Entities;

namespace TodoTask.Infrastructure.Mappers
{
    public class RequestMapperProfile : Profile
    {
        public RequestMapperProfile() 
        {
            CreateMap<CreateRequestDto, RequestModel>();
            CreateMap<UpdateRequestStatusDto, RequestModel>();
            CreateMap<RequestStatusEnum, string>().ConvertUsing(status => status.GetEnumMemberValue());
            CreateMap<GetRequestDto, RequestModel>().ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status));
            CreateMap<RequestModel, RequestEntity>();
            CreateMap<RequestModel, GetRequestDto>();
            CreateMap<RequestEntity, RequestModel>();
            CreateMap<UpdateRequestDto, RequestModel>();
            CreateMap<CreateAssignDriverDto, RequestModel>();
        }


    }

    public static class EnumExtensions
    {
        public static string GetEnumMemberValue(this RequestStatusEnum status)
        {
            var enumMemberAttribute = typeof(RequestStatusEnum)
                        .GetField(status.ToString())
                        ?.GetCustomAttributes(typeof(EnumMemberAttribute), false)
                        .FirstOrDefault() as EnumMemberAttribute;

            return enumMemberAttribute?.Value ?? status.ToString();
        }
    }
}
