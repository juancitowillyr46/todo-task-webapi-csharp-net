using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoTask.Domain.Models;

namespace TodoTask.Domain.Ports.Outbound
{
    public interface IRequestRepository
    {
        RequestModel CreateRequest(RequestModel requestModel);

        bool UpdateRequest(int requestId, RequestModel requestModel);
    }
}
