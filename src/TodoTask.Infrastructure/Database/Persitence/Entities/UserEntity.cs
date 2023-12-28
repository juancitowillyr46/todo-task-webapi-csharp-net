using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoTask.Infrastructure.Database.Persitence.Entities.Base;

namespace TodoTask.Infrastructure.Database.Persitence.Entities
{
    public class UserEntity : BaseEntity
    {
        public string? FullName { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public bool Blocked { get; set; }
        public List<RequestEntity>? Requests { get; set; } = new List<RequestEntity>();
    }
}
