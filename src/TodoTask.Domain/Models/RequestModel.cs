using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoTask.Domain.Enums;
using TodoTask.Domain.Models.Base;

namespace TodoTask.Domain.Models
{
    public class RequestModel : BaseModel
    {
        public decimal OriginLatitude { get; set; }
        public decimal OriginLongitude { get; set; }
        public string? OriginAddress { get; set; }
        public decimal DestinationLatitude { get; set; }
        public decimal DestinationLongitude { get; set; }
        public string? DestinationAddress { get; set; }
        public int UserId { get; set; }
        public int? DriverId { get; set; }
        public RequestStatusEnum Status { get; set; }
    }
}
