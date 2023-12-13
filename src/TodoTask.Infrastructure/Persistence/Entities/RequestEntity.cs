using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoTask.Domain.Enums;
using TodoTask.Infrastructure.Persistence.Entities.Base;

namespace TodoTask.Infrastructure.Persistence.Entities
{
    public class RequestEntity : BaseEntity
    {
        public int UserId { get; set; }
        public UserEntity? User { get; set; }
        public int? AssetId { get; set; } = null;
        public AssetEntity? Asset { get; set; }
        public decimal OriginLatitude { get; set; }
        public decimal OriginLongitude { get; set; }
        public string? OriginAddress { get; set; }
        public decimal DestinationLatitude { get; set; }
        public decimal DestinationLongitude { get; set; }
        public string? DestinationAddress { get; set; }
        public RequestStatus Status { get; set; }
    }
}
