using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoTask.Infrastructure.Database.Persitence.Entities.Base;

namespace TodoTask.Infrastructure.Database.Persitence.Entities
{
    public class ClientEntity : BaseEntity
    {
        public int UserId { get; set; }
        public UserEntity? User { get; set; }
        public int PersonId { get; set; }
        public PersonEntity? Person { get; set; }
        public List<ClientLocationEntity>? Locations { get; set; } = new List<ClientLocationEntity>();
    }
}
