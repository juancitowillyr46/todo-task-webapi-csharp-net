using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoTask.Domain.Enums;
using TodoTask.Infrastructure.Persistence.Entities.Base;

namespace TodoTask.Infrastructure.Persistence.Entities
{
    public class VehicleEntity : BaseEntity
    {
        public int DeviceId {  get; set; }
        public DeviceEntity? Device {  get; set; }
        public string PlateNumber { get; set; } = string.Empty;
    }
}
