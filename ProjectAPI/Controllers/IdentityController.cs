using Data.Services.Dto;
using Data.Services.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace MusicAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IdentityController : ControllerBase
    {
        private readonly UserService _service;

        public IdentityController(UserService userService)
        {
            this._service = userService;
        }
        [HttpGet]
        public IActionResult Register([FromQuery] RegisterModel model)
        {
            var token = _service.Register(model);
            if (string.IsNullOrEmpty(token))
            {
                return BadRequest();
            }
            return Ok(token);
        }
        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            var token = _service.Login(model);
            if (string.IsNullOrEmpty(token))
            {
                return BadRequest();
            }
            return Ok(token);
        }
        [Authorize]
        [HttpPost]
        [Route("changepassword")]
        public IActionResult ChangePassword(ChangePassword changePassword)
        {
            string username;
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            username = identity.Name;


            return Ok(_service.ChangePassword(username,changePassword));
        }
        [Authorize]
        [Route("changeusername")]
        [HttpPost]
        public IActionResult ChangeUsername(string newUsername)
        {
            string username;
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            username = identity.Name;
            string token = _service.ChangeUsername(username, newUsername);


            return Ok(token);
        }
    }
}
