using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoTask.Application.Dtos.Device;
using TodoTask.Application.Dtos.Driver;
using TodoTask.Domain.Models;

namespace TodoTask.Application.Dtos.Vehicle
{
    public class GetVehicleDto
    {
        public GetDeviceDto? Device { get; set; }
        public GetDriverDto? Driver { get; set; }
        public string PlateNumber { get; set; } = string.Empty;
    }
}
