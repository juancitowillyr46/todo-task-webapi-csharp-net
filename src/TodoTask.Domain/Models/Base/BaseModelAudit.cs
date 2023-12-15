using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoTask.Domain.Models.Base
{
    public abstract class BaseModelAudit
    {
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; } = DateTime.Now;
        public int? UpdatedBy { get; set; }
        public DateTime? DeletedAt { get; set; } = DateTime.Now;
        public int? DeletedBy { get; set; }
    }
}
