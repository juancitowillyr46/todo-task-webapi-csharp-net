using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoTask.Domain.Enums;

namespace TodoTask.Application.Dtos.Request
{
    public class UpdateRequestStatusDto
    {
        public int RequestId { get; set; }
        public RequestStatusEnum? Status { get; set; }
    }
}
