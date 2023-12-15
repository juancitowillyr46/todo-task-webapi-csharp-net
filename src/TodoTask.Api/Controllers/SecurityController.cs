using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using TodoTask.Application.Dtos.User;
using TodoTask.Domain.Models;
using TodoTask.Domain.Ports.Inbound;
using TodoTask.Infrastructure.Persistence.Entities;

namespace TodoTask.Api.Controllers
{
    public class SecurityController : BaseController
    {
        private readonly ISecurityService _securityService;
        private readonly IMapper _mapper;

        public SecurityController(ISecurityService securityService, IMapper mapper)
        {
            _securityService = securityService;
            _mapper = mapper;
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public IActionResult PostLogin([FromBody] UserLoginDto userLoginDto)
        {
            var token = _securityService.PostLogin(userLoginDto.UserName!, userLoginDto.Password!);
            if (token != null)
            {
                return Ok(new { Token = token });
            }
            return Unauthorized();
        }

        [AllowAnonymous]
        [HttpPost("register")]
        public IActionResult PostRegister([FromBody] UserRegisterDto userRegisterDto)
        {
            UserModel userRegister = _mapper.Map<UserModel>(userRegisterDto);
            UserModel getRegister = _securityService.PostRegister(userRegister);
            GetRegisterUserDto getRegisterUser = _mapper.Map<GetRegisterUserDto>(getRegister);
            return Ok(getRegisterUser);
        }
    }
}
