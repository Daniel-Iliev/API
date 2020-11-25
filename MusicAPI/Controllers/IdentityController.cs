using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Services.Dto;
using Data.Services.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MusicAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IdentityController : ControllerBase
    {
        private readonly UserService userService;

        public IdentityController(UserService userService)
        {
            this.userService = userService;
        }
        [HttpGet]
        public IActionResult Register(RegisterModel model)
        {
            var token = userService.Register(model);
            if (string.IsNullOrEmpty(token))
            {
                return BadRequest();
            }
            return Ok(token);
        }
        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            var token = userService.Login(model);
            if (string.IsNullOrEmpty(token))
            {
                return BadRequest();
            }
            return Ok(token);
        }
    }
}
