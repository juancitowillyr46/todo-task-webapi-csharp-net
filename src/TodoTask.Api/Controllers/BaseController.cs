using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TodoTask.Application.Dtos.Request;
using TodoTask.Domain.Models;
using TodoTask.Domain.Ports.Inbound;

namespace TodoTask.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseController : ControllerBase
    {
        //public int GetUserIdFromHttpContext()
        //{
        //    var httpContext = HttpContext;
        //    if (httpContext.Items.TryGetValue("UserId", out var userIdObj) && userIdObj != null)
        //    {
        //        return int.Parse((string)userIdObj!);
        //    }
        //    // En este punto, debes decidir qué valor devolver si no puedes obtener el UserId.
        //    // Podrías lanzar una excepción, devolver un valor predeterminado o tomar otra acción según tus necesidades.
        //    return -1; // Por ejemplo, devolver -1 si no se puede obtener el UserId.
        //}
    }
}
