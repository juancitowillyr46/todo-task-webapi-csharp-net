using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoTask.Domain.Models;
using TodoTask.Domain.Ports.Outbound;
using TodoTask.Infrastructure.Persistence.Database;
using TodoTask.Infrastructure.Persistence.Entities;

namespace TodoTask.Infrastructure.Adapters
{
    public class VehicleRepository : BaseRepository, IVehicleRepository
    {
        public VehicleRepository(TodoTaskDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        public List<VehicleModel> FindVehiclesAvailability()
        {
            List<VehicleEntity>? vehicleEntities = _dbContext.Vehicles?
                                                                       .Include(v => v.Device)
                                                                       .Include(v => v.Driver)
                                                                       .Where(c => c.Availability == true)
                                                                       .ToList();
            var vehicles = _mapper.Map<List<VehicleModel>>(vehicleEntities);
            return vehicles;
        }
    }
}
