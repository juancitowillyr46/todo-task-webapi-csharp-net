using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoTask.Infrastructure.Persistence.Entities.Base;

namespace TodoTask.Infrastructure.Persistence.Entities
{
    public class DeviceEntity : BaseEntity
    {
        public string? Name { get; set; }
        public AssetEntity? Asset { get; set; }
        public int AssetId { get; set; }
    }
}
