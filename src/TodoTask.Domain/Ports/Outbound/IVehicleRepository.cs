﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoTask.Domain.Models;

namespace TodoTask.Domain.Ports.Outbound
{
    public interface IVehicleRepository
    {
        List<VehicleModel> FindVehiclesAvailability();
        bool UpdateVehicleAvailability(int vehicleId, bool availability);
    }
}
