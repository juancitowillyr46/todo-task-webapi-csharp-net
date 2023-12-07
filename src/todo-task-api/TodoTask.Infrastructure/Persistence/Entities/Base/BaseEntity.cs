using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoTask.Infrastructure.Persistence.Entities.Base
{
    public class BaseEntity : BaseAuditEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
