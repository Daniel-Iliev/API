using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Data.Services.Dto;
using Data.Services.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace MusicAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IWebHostEnvironment webHostEnvironment;
        private IConfiguration _configuration;
        private UsersService _service;

        public UsersController(IWebHostEnvironment env, IConfiguration configuration, UsersService service)
        {
            webHostEnvironment = env;

            _configuration = configuration;
            _service = service;

        }
        [Route("getall")]
        [HttpGet]
        public IActionResult GetAll(string order,bool decending)
        {
            return Ok(_service.GetAll(order,decending));
        }
        [Authorize]
        [Route("addfav")]
        [HttpPost]
        public IActionResult AddFavourite(string songName)
        {
            string username;
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            username = identity.Name;
            return Ok(_service.AddFavourite(username,songName));
        }
        [Authorize]
        [Route("deletefav")]
        [HttpDelete]
        public IActionResult DeleteFavourite(string songName)
        {
            string username;
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            username = identity.Name;

            return Ok(_service.DeleteFavourite(username,songName));
        }


    }
}