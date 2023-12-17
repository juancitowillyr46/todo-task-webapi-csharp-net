using AutoMapper;
using Microsoft.EntityFrameworkCore;
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
    public class AssetRepository : IAssetRepository
    {
        private readonly TodoTaskDbContext _dbContext;
        private readonly IMapper _mapper;

        public AssetRepository(TodoTaskDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public List<AssetModel> FindAssetAvailability()
        {
            List<AssetEntity>? assetEntities = new();
            // _dbContext?.Assets?
            //.Where(c => c.Availability == true).ToList()
            var destinationList = _mapper.Map<List<AssetModel>>(assetEntities);
            return destinationList;
        }

        public AssetModel FindAssetById(int assetId)
        {
            AssetEntity? assetEntity = new();
            // _dbContext.Assets?.Find(assetId)
            return _mapper.Map<AssetModel>(assetEntity);
        }

        public bool UpdateAssetAvailability(int assetId, AssetModel assetModel)
        {
            AssetEntity? assetEntity = new();
            // AssetEntity? assetEntity = _dbContext.Assets?.Find(assetId);
            if (assetEntity != null)
            {
                assetEntity.Availability = assetModel.Availability;
                assetEntity.UpdatedBy = assetModel.UpdatedBy;
                assetEntity.UpdatedAt = assetModel.UpdatedAt;
                _dbContext.SaveChanges();
            }
            return assetEntity != null;
        }
    }
}
