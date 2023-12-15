using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoTask.Application.Dtos.User
{
    public class UserRegisterDto
    {
        public string? FirstName { get; set; }
        public string? SecondName { get; set; }
        public string? LastName { get; set; }
        public string? UserName { get; set; }
        public string? SecondLastName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}
