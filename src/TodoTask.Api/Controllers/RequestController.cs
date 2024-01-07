using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using TodoTask.Application.Dtos.Request;
using TodoTask.Domain.Enums;
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
            var httpContext = HttpContext;
            RequestModel toModel = _mapper.Map<RequestModel>(createRequestDto);
            if (httpContext.Items.TryGetValue("UserId", out var userId))
            {
                toModel.UserId = int.Parse( (string) userId!);
            }
            
            RequestModel model = _requestService.CreateRequest(toModel);
            GetRequestDto getRequestDto = _mapper.Map<GetRequestDto>(model);
            return getRequestDto;
        }

        [HttpPut("{requestId}/assign-driver")]
        public IActionResult AssignDriver(CreateAssignDriverDto dto)
        {
            var httpContext = HttpContext;
            RequestModel toModel = _mapper.Map<RequestModel>(dto);
            if (httpContext.Items.TryGetValue("UserId", out var userId))
            {
                toModel.UserId = int.Parse((string)userId!);
            }
            bool success = _requestService.AssignDriver(dto.RequestId, toModel);
            return Ok(success);
        }

        [HttpPut("{requestId}")]
        public bool Put(int requestId, [FromBody] UpdateRequestDto updateRequestDto)
        {
            RequestModel toModel = _mapper.Map<RequestModel>(updateRequestDto);
            bool done = _requestService.UpdateRequest(requestId, toModel);
            return done;
        }

        [HttpGet("{requestId}")]
        public IActionResult Get(int requestId)
        {
            RequestModel requestModel = _requestService.GetRequest(requestId);
            GetRequestDto getRequestDto = _mapper.Map<GetRequestDto>(requestModel);
            return Ok(getRequestDto);
        }
    }
}
