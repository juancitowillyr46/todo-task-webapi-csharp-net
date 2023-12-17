using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoTask.Domain.Enums;

namespace TodoTask.Application.Dtos.Person
{
    public class GetPersonDto
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
