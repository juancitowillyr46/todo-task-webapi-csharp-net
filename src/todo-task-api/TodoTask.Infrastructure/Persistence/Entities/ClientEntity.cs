using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoTask.Infrastructure.Persistence.Entities.Base;

namespace TodoTask.Infrastructure.Persistence.Entities
{
    public class ClientEntity : BaseEntity
    {
        public List<ClientLocationEntity>? Locations { get; set; } = new List<ClientLocationEntity>();
    }
}
