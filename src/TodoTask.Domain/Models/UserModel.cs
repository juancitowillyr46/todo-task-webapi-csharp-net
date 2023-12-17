using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoTask.Domain.Models.Base;

namespace TodoTask.Domain.Models
{
    public class UserModel : BaseModel
    {
        public string? Firstname { get; set; }
        public string? Secondname { get; set; }
        public string? Lastname { get; set; }
        public string? Username { get; set; }
        public string? SecondLastname { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public bool Blocked { get; set; }
    }
}
