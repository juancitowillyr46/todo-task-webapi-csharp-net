using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoTask.Domain.Models.Base;

namespace TodoTask.Domain.Models
{
    public class AssetModel : BaseModel
    {
        public string? Name { get; set; }
        public bool Availability { get; set; }
    }
}
