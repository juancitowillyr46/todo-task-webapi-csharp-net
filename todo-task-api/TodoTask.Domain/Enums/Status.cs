using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoTask.Domain.Enums
{
    public enum RequestStatus
    {
        PENDING = 0,
        ACCEPTED = 1,
        ON_ROUTE = 2,
        COMPLETED = 3
    }
}
