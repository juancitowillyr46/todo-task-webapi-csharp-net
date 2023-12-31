﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoTask.Infrastructure.Database.Persitence.Entities.Base;

namespace TodoTask.Infrastructure.Database.Persitence.Entities
{
    public class DriverLocationEntity : BaseEntity
    {
        public int DriverId { get; set; }
        public DriverEntity? Driver { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public DateTime? Timestamp { get; set; } = DateTime.Now;
    }
}
