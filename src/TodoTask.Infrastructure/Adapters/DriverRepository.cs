using AutoMapper;
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
    public class DriverRepository : BaseRepository, IDriverRepository
    {
        public DriverRepository(TodoTaskDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        public List<DriverModel> DriversAvailable()
        {
            List<DriverEntity>? driversEntities = _dbContext.Drivers?.Where(d => d.Availability == true).ToList();
            var vehicles = _mapper.Map<List<DriverModel>>(driversEntities);
            return vehicles;
        }
    }
}
