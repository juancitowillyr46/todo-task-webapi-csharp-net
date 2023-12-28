using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoTask.Domain.Models;
using TodoTask.Domain.Ports.Inbound;
using TodoTask.Domain.Ports.Outbound;
using TodoTask.Infrastructure.Exceptions;

namespace TodoTask.Application.Services
{
    public class VehicleService : IVehicleService
    {
        private readonly IVehicleRepository _vehicleRepository;   
        
        public VehicleService(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        public List<VehicleModel> FindVehiclesAvailability()
        {
            return _vehicleRepository.FindVehiclesAvailability();
        }

        public bool UpdateVehicleAvailability(int vehicleId, bool availability)
        {
            var success = _vehicleRepository.UpdateVehicleAvailability(vehicleId, availability);
            if (!success)
            {
                throw new NotFoundException("Valid: Vehicle no exist");
            }
            return success;
        }
    }
}
