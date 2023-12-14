using AutoMapper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoTask.Application.Dtos.Asset;
using TodoTask.Application.Exceptions;
using TodoTask.Application.Services;
using TodoTask.Domain.Models;
using TodoTask.Domain.Ports.Inbound;

namespace TodoTask.Api.Controllers
{
    [Authorize]
    public class AssetController : BaseController
    {
        private readonly IAssetService _assetService;
        private readonly IMapper _mapper;

        public AssetController(IAssetService assetService, IMapper mapper) 
        { 
            _assetService = assetService;
            _mapper = mapper;
        }

        [HttpGet("availability")]
        public List<GetAssetDto> GetAvailability()
        //public IActionResult GetAvailability()
        {
            var httpContext = HttpContext;
            //var getUserIdContext = new Object();
            //var userId = String.Empty;
            if (httpContext.Items.TryGetValue("UserId", out var userId))
            {
                // Haz algo con el ID del usuario
                //return Ok($"ID del Usuario: {userId}");
                //getUserIdContext = userId;
            }
            List<AssetModel> assetsModel = _assetService.FindAssetAvailability();
            var destinationList = _mapper.Map<List<GetAssetDto>>(assetsModel);
            return destinationList;
            //Ok(userId);
        }

        [HttpPut("availability/{assetId}")]
        public bool PutAssetAvailability(int assetId, UpdateAssetAvailabilityDto availability)
        {
            bool done = _assetService.UpdateAssetAvailability(assetId, availability.Availability);
            return done;
        }
    }
}
