using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoTask.Infrastructure.Persistence.Entities.Base
{
    public class BaseAuditEntity
    {
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public int? CreatedBy { get; set; }   
        public DateTime? UpdatedAt { get; set; } = DateTime.Now;
        public int? UpdatedBy { get; set; }
        public DateTime? DeletedAt { get; set; } = DateTime.Now;
        public int? DeletedBy { get; set; }
    }
}
