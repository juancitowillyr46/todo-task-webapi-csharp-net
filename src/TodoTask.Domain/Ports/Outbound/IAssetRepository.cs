using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoTask.Domain.Models;

namespace TodoTask.Domain.Ports.Outbound
{
    public interface IAssetRepository
    {
        List<AssetModel> FindAssetAvailability();
        bool UpdateAssetAvailability(int assetId, AssetModel assetModel);
        AssetModel FindAssetById(int assetId);
    }
}
