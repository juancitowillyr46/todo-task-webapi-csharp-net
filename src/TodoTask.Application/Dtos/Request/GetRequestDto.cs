using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoTask.Domain.Enums;

namespace TodoTask.Application.Dtos.Request
{
    public class GetRequestDto
    {
        public int Id { get; set; }
        public decimal OriginLatitude { get; set; }
        public decimal OriginLongitude { get; set; }
        public string? OriginAddress { get; set; }
        public decimal DestinationLatitude { get; set; }
        public decimal DestinationLongitude { get; set; }
        public string? DestinationAddress { get; set; }
        public string Status { get; set; } = string.Empty;
    }
}
