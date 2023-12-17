using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoTask.Application.Dtos.Person;

namespace TodoTask.Application.Dtos.Driver
{
    public class GetDriverDto
    {
        public GetPersonDto? Person { get; set; }
        public string LicenseNumber { get; set; } = string.Empty;
    }
}
