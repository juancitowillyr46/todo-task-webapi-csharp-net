using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoTask.Domain.Enums;
using TodoTask.Infrastructure.Persistence.Entities.Base;

namespace TodoTask.Infrastructure.Persistence.Entities
{
    public class AssetEntity : BaseEntity
    {
        public string? Name { get; set; }
        public AssetTypeEnum Type { get; set; } = AssetTypeEnum.AUTO;
        public DeviceEntity? Device { get; set; }
        public List<RequestEntity>? Requests { get; set; } = new List<RequestEntity>();
        public List<AssetLocationEntity>? Locations { get; set; } = new List<AssetLocationEntity>();
        public bool Availability { get; set; }
    }
}
