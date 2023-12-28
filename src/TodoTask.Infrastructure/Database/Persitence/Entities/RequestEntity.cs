using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoTask.Domain.Enums;
using TodoTask.Infrastructure.Database.Persitence.Entities.Base;

namespace TodoTask.Infrastructure.Database.Persitence.Entities
{
    public class RequestEntity : BaseEntity
    {
        //public int ClientId { get; set; }
        //public ClientEntity? Client { get; set; }
        public int? DriverId { get; set; } = null;
        public DriverEntity? Driver { get; set; }
        public decimal OriginLatitude { get; set; }
        public decimal OriginLongitude { get; set; }
        public string? OriginAddress { get; set; }
        public decimal DestinationLatitude { get; set; }
        public decimal DestinationLongitude { get; set; }
        public string? DestinationAddress { get; set; }
        public RequestStatusEnum? Status { get; set; } = RequestStatusEnum.PENDING;

        public int UserId { get; set; }
        public UserEntity? User { get; set; }
    }
}
