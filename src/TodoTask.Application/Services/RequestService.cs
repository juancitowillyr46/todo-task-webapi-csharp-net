using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoTask.Domain.Enums;
using TodoTask.Domain.Models;
using TodoTask.Domain.Ports.Inbound;
using TodoTask.Domain.Ports.Outbound;
using TodoTask.Infrastructure.Exceptions;

namespace TodoTask.Application.Services
{
    public class RequestService : IRequestService
    {
        private readonly IRequestRepository _requestRepository;

        public RequestService(IRequestRepository requestRepository)
        {
            _requestRepository = requestRepository;
        }

        public bool AssignDriver(int requestId, RequestModel requestModel)
        {
            requestModel.UpdatedAt = DateTime.Now;
            requestModel.UpdatedBy = requestModel.UserId;
            requestModel.DriverId = requestModel.DriverId;
            requestModel.Status = RequestStatusEnum.ACCEPTED;
            return _requestRepository.AssignDriver(requestId, requestModel);
        }


        public RequestModel CreateRequest(RequestModel requestModel)
        {
            requestModel.Status = RequestStatusEnum.PENDING;
            requestModel.DriverId = null;
            if (_requestRepository.FindAwaitingRequestsByUser(requestModel.UserId))
            {
                throw new NotFoundException("The user has a pending request");
            }
            return _requestRepository.CreateRequest(requestModel);
        }

        public RequestModel GetRequest(int requestId)
        {
            return _requestRepository.GetRequest(requestId);
        }

        public bool UpdateRequest(int requestId, RequestModel requestModel)
        {
            return _requestRepository.UpdateRequest(requestId, requestModel);
        }
    }
}
