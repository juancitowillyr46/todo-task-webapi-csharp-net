using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoTask.Application.Dtos.Driver;
using TodoTask.Application.Dtos.Vehicle;
using TodoTask.Domain.Models;
using TodoTask.Domain.Ports.Inbound;

namespace TodoTask.Api.Controllers
{
    [Authorize]
    public class DriverController : BaseController
    {
        private readonly IDriverService _driverService;
        private readonly IMapper _mapper;
        public DriverController(IDriverService driverService, IMapper mapper)
        {
            _driverService = driverService;
            _mapper = mapper;
        }

        [HttpGet("available")]
        public IActionResult GetAvailable()
        {
            List<DriverModel> driversModel = _driverService.DriversAvailable();
            var drivers = _mapper.Map<List<GetDriverDto>>(driversModel);
            return Ok(drivers);
        }
    }
}
