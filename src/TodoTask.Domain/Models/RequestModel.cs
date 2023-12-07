using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoTask.Domain.Enums;

namespace TodoTask.Domain.Models
{
    public class RequestModel
    {
        public int Id { get; set; }
        public decimal OriginLatitude { get; set; }
        public decimal OriginLongitude { get; set; }
        public decimal DestinationLatitude { get; set; }
        public decimal DestinationLongitude { get; set; }
        public int UserId { get; set; }
        public int? AssetId { get; set; }
        public RequestStatus Status { get; set; }
    }
}
