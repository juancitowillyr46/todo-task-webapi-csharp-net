﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoTask.Domain.Models;

namespace TodoTask.Domain.Ports.Inbound
{
    public interface IVehicleService
    {
        List<VehicleModel> FindVehiclesAvailability();
        bool UpdateVehicleAvailability(int vehicleId, bool availability);
    }
}
