using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoTask.Domain.Enums;
using TodoTask.Domain.Models.Base;

namespace TodoTask.Domain.Models
{
    public class PersonModel : BaseModel
    {
        public DocumentTypeEnum DocumentType { get; set; } = DocumentTypeEnum.DNI;
        public string DocumentNumber { get; set; } = string.Empty;
        public string? FirstName { get; set; }
        public string? SecondName { get; set; }
        public string? LastName { get; set; }
        public string? SecondLastName { get; set; }
        public string? Email { get; set; }
    }
}
