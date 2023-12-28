using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoTask.Application.Dtos.Asset;
using TodoTask.Application.Dtos.User;
using TodoTask.Application.Dtos.Vehicle;
using TodoTask.Application.Services;
using TodoTask.Domain.Models;
using TodoTask.Domain.Ports.Inbound;

namespace TodoTask.Api.Controllers
{
    [Authorize]
    public class VehicleController : BaseController
    {
        private readonly IVehicleService _vehicleService;
        private readonly IMapper _mapper;
        public VehicleController(IVehicleService vehicleService, IMapper mapper)
        {
            _vehicleService = vehicleService;
            _mapper = mapper;
        }

        [HttpGet("availability")]
        public IActionResult GetVehiclesAvailability()
        {
            List<VehicleModel> vehiclesModel = _vehicleService.FindVehiclesAvailability();
            var GetVehicles = _mapper.Map<List<GetVehicleDto>>(vehiclesModel);
            return Ok(GetVehicles);
        }

        [HttpPut("availability/{vehicleId}")]
        public IActionResult PutAssetAvailability(int vehicleId, VehicleAvailabilityDto vehicleAvailabilityDto)
        {
            bool done = _vehicleService.UpdateVehicleAvailability(vehicleId, vehicleAvailabilityDto.Availability);
            return Ok(done);
        }
    }
}
