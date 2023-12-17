using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TodoTask.Domain.Enums;
using TodoTask.Infrastructure.Persistence.Entities.Base;

namespace TodoTask.Infrastructure.Persistence.Entities
{
    public class PersonEntity : BaseEntity
    {
        public DocumentTypeEnum DocumentType { get; set; } = DocumentTypeEnum.DNI;
        public string DocumentNumber { get; set; } = string.Empty;
        public string? Firstname { get; set; }
        public string? Secondname { get; set; }
        public string? Lastname { get; set; }
        public string? SecondLastname { get; set; }
        public string? Email { get; set; }
    }
}
