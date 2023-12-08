using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TodoTask.Application.Dtos.Request;
using TodoTask.Domain.Models;
using TodoTask.Domain.Ports.Inbound;

namespace TodoTask.Api.Controllers
{
    public class RequestController : BaseController
    {
        private readonly IRequestService _requestService;
        private readonly IMapper _mapper;
        public RequestController (IRequestService requestService, IMapper mapper)
        {
            _mapper = mapper;
            _requestService = requestService;
        }

        [HttpPost()]
        public GetRequestDto Post(CreateRequestDto createRequestDto)
        {
            RequestModel toModel = _mapper.Map<RequestModel>(createRequestDto);
            toModel.UserId = 1;
            RequestModel model = _requestService.CreateRequest(toModel);
            GetRequestDto getRequestDto = _mapper.Map<GetRequestDto>(model);
            return getRequestDto;
        }

        [HttpPut("{requestId}")]
        public bool Put(int requestId, [FromBody] UpdateRequestDto updateRequestDto)
        {
            RequestModel toModel = _mapper.Map<RequestModel>(updateRequestDto);
            bool done = _requestService.UpdateRequest(requestId, toModel);
            return done;
        }
    }
}
