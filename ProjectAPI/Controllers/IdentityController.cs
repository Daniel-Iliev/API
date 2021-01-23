using Data.Services.Dto;
using Data.Services.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Security.Principal;

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
        [Route("register")]
        [HttpPost]
        public IActionResult Register(RegisterModel model)
        {
            var token = _service.Register(model);
            if (string.IsNullOrEmpty(token))
            {
                return BadRequest();
            }
            return Ok(token);
        }
        [Route("login")]
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
        [Route("changepassword")]
        [HttpPost]
        
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
        [Authorize]
        [Route("deleteaccount")]
        [HttpDelete]
        public IActionResult DeleteAccount(string password)
        {
            string username;
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            username = identity.Name;
            string token = _service.DeleteAccount(password,username);


            return Ok(token);
        }
    }
}
