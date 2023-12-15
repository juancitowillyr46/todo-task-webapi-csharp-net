using Microsoft.AspNetCore.Mvc;
using TodoTask.Application.Dtos.Request;
using TodoTask.Application.Dtos.User;
using TodoTask.Domain.Ports.Inbound;

namespace TodoTask.Api.Controllers
{
    public class UserController : BaseController
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("")]
        public IActionResult PostSecurityLogin([FromBody] UserLoginDto userLoginDto)
        {
            _userService.GetUserByUsername(userLoginDto.UserName!);
            return Ok();
        }
    }
}
