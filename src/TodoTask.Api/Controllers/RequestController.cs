using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TodoTask.Application.Dtos;
using TodoTask.Domain.Models;
using TodoTask.Domain.Ports.Inbound;
using TodoTask.Infrastructure.Dtos;

namespace TodoTask.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestController : ControllerBase
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
    }
}
