﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoTask.Infrastructure.Persistence.Entities.Base;

namespace TodoTask.Infrastructure.Persistence.Entities
{
    public class UserEntity : BaseEntity
    {
        public string? FirstName { get; set; }
        public string? SecondName { get; set; }
        public string? LastName { get; set; }
        public string? SecondLastName { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public bool Blocked { get; set; }
        public List<RequestEntity>? Requests { get; set; } = new List<RequestEntity>();
    }
}
