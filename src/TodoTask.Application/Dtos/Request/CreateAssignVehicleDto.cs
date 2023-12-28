using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoTask.Application.Dtos.Request
{
    public class CreateAssignVehicleDto
    {
        public int RequestId { get; set; }
        public int DriverId { get; set; }
    }
}
