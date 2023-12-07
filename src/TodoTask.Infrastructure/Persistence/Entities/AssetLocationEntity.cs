using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoTask.Infrastructure.Persistence.Entities.Base;

namespace TodoTask.Infrastructure.Persistence.Entities
{
    public class AssetLocationEntity : BaseEntity
    {
        public int AssetId { get; set; }
        public AssetEntity? Asset { get; set;}
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public DateTime? Timestamp { get; set; } = DateTime.Now;
    }
}
