﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoTask.Domain.Enums;
using TodoTask.Infrastructure.Database.Persitence.Entities.Base;

namespace TodoTask.Infrastructure.Database.Persitence.Entities
{
    public class DriverEntity : BaseEntity
    {
        public int UserId { get; set; }
        public UserEntity? User { get; set; }
        public int PersonId { get; set; }
        public PersonEntity? Person { get; set; }
        public string LicenseNumber { get; set; } = string.Empty;
        public List<DriverLocationEntity>? Locations { get; set; } = new List<DriverLocationEntity>();
        public List<RequestEntity>? Requests { get; set; } = new List<RequestEntity>();
        public bool Availability { get; set; }
    }
}
