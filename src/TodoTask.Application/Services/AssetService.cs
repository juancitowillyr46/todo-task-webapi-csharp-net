using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoTask.Domain.Models;
using TodoTask.Domain.Ports.Inbound;
using TodoTask.Domain.Ports.Outbound;

namespace TodoTask.Application.Services
{
    public class AssetService : IAssetService
    {
        private readonly IAssetRepository _assetRepository;

        public AssetService(IAssetRepository assetRepository)
        {
            _assetRepository = assetRepository;
        }

        public List<AssetModel> FindAssetAvailability()
        {
            return _assetRepository.FindAssetAvailability();
        }

        public bool UpdateAssetAvailability(int assetId, bool availability)
        {
            AssetModel assetModel = new()
            {
                UpdatedBy = 1,
                UpdatedAt = DateTime.Now,
                Availability = availability
            };
            return _assetRepository.UpdateAssetAvailability(assetId, assetModel);
        }
    }
}
