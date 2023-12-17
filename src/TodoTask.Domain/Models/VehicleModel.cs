using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoTask.Domain.Models.Base;

namespace TodoTask.Domain.Models
{
    public class VehicleModel : BaseModel
    {
        public DeviceModel? Device { get; set; }
        public DriverModel? Driver { get; set; }
        public string PlateNumber { get; set; } = string.Empty;
    }
}
