using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoTask.Domain.Models.Base
{
    public class BaseModel : BaseModelAudit
    {
        public int Id { get; set; }
    }
}
