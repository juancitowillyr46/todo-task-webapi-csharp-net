using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoTask.Domain.Enums;
using TodoTask.Infrastructure.Database.Persitence.Entities.Base;

namespace TodoTask.Infrastructure.Database.Persitence.Entities
{
    public class VehicleEntity : BaseEntity
    {
        public int DeviceId { get; set; }
        public DeviceEntity? Device { get; set; }
        public string PlateNumber { get; set; } = string.Empty;
        //public bool Availability { get; set; }
        public VehicleTypeEnum Type { get; set; } = VehicleTypeEnum.AUTO;
        public int DriverId { get; set; }
        public DriverEntity? Driver { get; set; }
    }
}
