using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoTask.Application.Dtos.Request;
using TodoTask.Infrastructure.Persistence.Entities;

namespace TodoTask.Infrastructure.Mappers
{
    public class RequestMapper
    {
        public static GetRequestDto MapToDto(RequestEntity request)
        {
            return new GetRequestDto
            {
                Id = request.Id,
                OriginLatitude = request.OriginLatitude,
                OriginLongitude = request.OriginLongitude,
                DestinationLatitude = request.DestinationLatitude,
                DestinationLongitude = request.DestinationLongitude
            };
        }

        public static RequestEntity MapToModel(GetRequestDto getRequestDto)
        {
            return new RequestEntity
            {
                Id = getRequestDto.Id,
                OriginLatitude = getRequestDto.OriginLatitude,
                OriginLongitude = getRequestDto.OriginLongitude,
                DestinationLatitude = getRequestDto.DestinationLatitude,
                DestinationLongitude= getRequestDto.DestinationLongitude
            };        
        }

    }
}
