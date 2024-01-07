using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TodoTask.Domain.Enums
{
    public enum RequestStatusEnum
    {
        [EnumMember(Value = "Pending")]
        PENDING = 0,

        [EnumMember(Value = "Approved")]
        ACCEPTED = 1,

        [EnumMember(Value = "On Route")]
        ON_ROUTE = 2,

        [EnumMember(Value = "Complete")]
        COMPLETED = 3
    }
}
