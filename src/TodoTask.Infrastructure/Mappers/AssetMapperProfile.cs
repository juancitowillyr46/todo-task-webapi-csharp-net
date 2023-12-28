using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoTask.Application.Dtos.Asset;
using TodoTask.Domain.Models;
using TodoTask.Infrastructure.Database.Persitence.Entities;

namespace TodoTask.Infrastructure.Mappers
{
    public class AssetMapperProfile : Profile
    {
        public AssetMapperProfile()
        {
            CreateMap<AssetModel, GetAssetDto>();
            CreateMap<AssetEntity, AssetModel>();
            CreateMap<AssetModel, AssetEntity>();
        }
    }
}
