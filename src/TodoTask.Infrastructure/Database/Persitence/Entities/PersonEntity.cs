using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TodoTask.Domain.Enums;
using TodoTask.Infrastructure.Database.Persitence.Entities.Base;

namespace TodoTask.Infrastructure.Database.Persitence.Entities
{
    public class PersonEntity : BaseEntity
    {
        public DocumentTypeEnum DocumentType { get; set; } = DocumentTypeEnum.DNI;
        public string DocumentNumber { get; set; } = string.Empty;
        public string? FirstName { get; set; }
        public string? SecondName { get; set; }
        public string? LastName { get; set; }
        public string? SecondLastName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? PhotoUrl { get; set; }
        public DateTime DateOfBirth { get; set; }
        public PersonGenderEnum Gender { get; set; } = PersonGenderEnum.MALE;

    }
}
