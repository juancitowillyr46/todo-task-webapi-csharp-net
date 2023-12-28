using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoTask.Domain.Models;
using TodoTask.Domain.Ports.Outbound;
using TodoTask.Infrastructure.Database;
using TodoTask.Infrastructure.Database.Persitence.Entities;

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
                                                                       .Include(v => v.Driver!)
                                                                            .ThenInclude(d => d.Person)
                                                                       //.Where(v => v.Availability == true)
                                                                       .ToList();
            vehicleEntities = vehicleEntities?.Where(v => v.Driver != null || v.Driver?.Person != null)
                .ToList();
            var vehicles = _mapper.Map<List<VehicleModel>>(vehicleEntities);
            return vehicles;
        }

        public bool UpdateVehicleAvailability(int vehicleId, bool availability)
        {
            VehicleEntity? vehicleEntity = _dbContext.Vehicles?.Find(vehicleId);
            if (vehicleEntity != null)
            {
                //vehicleEntity.Availability = availability;
                vehicleEntity.UpdatedBy = 1;
                vehicleEntity.UpdatedAt = DateTime.Now;
                _dbContext.SaveChanges();
            }
            return vehicleEntity != null;
        }
    }
}
