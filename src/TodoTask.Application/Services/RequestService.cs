using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public RequestModel CreateRequest(RequestModel requestModel)
        {
            if(_requestRepository.FindAwaitingRequestsByUser(requestModel.UserId))
            {
                throw new NotFoundException("The user has a pending request");
            }
            return _requestRepository.CreateRequest(requestModel);
        }

        public bool UpdateRequest(int requestId, RequestModel requestModel)
        {
            requestModel.AssetId = requestModel.AssetId;
            return _requestRepository.UpdateRequest(requestId, requestModel);
        }
    }
}
