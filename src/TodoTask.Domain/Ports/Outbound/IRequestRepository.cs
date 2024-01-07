using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoTask.Domain.Enums;
using TodoTask.Domain.Models;

namespace TodoTask.Domain.Ports.Outbound
{
    public interface IRequestRepository
    {
        RequestModel CreateRequest(RequestModel requestModel);

        bool UpdateRequest(int requestId, RequestModel requestModel);

        bool FindAwaitingRequestsByUser(int userId);

        bool AssignDriver(int requestId, RequestModel requestModel);

        RequestModel GetRequest(int requestId);

        bool UpdateRequestStatus(int requestId, RequestModel requestModel);

    }
}
