using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoTask.Domain.Models.Base;

namespace TodoTask.Domain.Models
{
    public class DriverModel : BaseModel
    {
        public string LicenseNumber { get; set; } = string.Empty;
    }
}
