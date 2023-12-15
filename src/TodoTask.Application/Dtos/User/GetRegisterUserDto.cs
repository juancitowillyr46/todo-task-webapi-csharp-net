using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoTask.Application.Dtos.User
{
    public class GetRegisterUserDto
    {
        public int Id { get; set; }
        public string UserName { get; set; } = string.Empty;
    }
}
