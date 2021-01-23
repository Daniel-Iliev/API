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


        [Authorize(Roles = "Admin")]
        [Route("getall")]
        [HttpGet]
        public IActionResult GetAll(string order,bool decending)
        {
            return Ok(_service.GetAll(order,decending));
        }


        [Authorize]
        [Route("getfavourites")]
        [HttpGet]
        public IActionResult GetFavourites()
        {
            string username;
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            username = identity.Name;
            return Ok(_service.GetFavourites(username));
        }


        [Authorize]
        [Route("addfavourite")]
        [HttpPost]
        public IActionResult AddFavourite(string songName)
        {
            string username;
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            username = identity.Name;
            return Ok(_service.AddFavourite(username,songName));
        }


        [Authorize(Roles = "Admin")]
        [Route("updateuserrole")]
        [HttpPost]
        public IActionResult UpdateUserRole(string username, string role)
        {
            return Ok(_service.UpdateUserRole(username, role));
        }


        [Authorize]
        [Route("deletefavourite")]
        [HttpDelete]
        public IActionResult DeleteFavourite(string songName)
        {
            string username;
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            username = identity.Name;

            return Ok(_service.DeleteFavourite(username,songName));
        }


        [Authorize(Roles = "Admin")]
        [Route("deleteuser")]
        [HttpDelete]
        public IActionResult DeleteUser(string username)
        {
            return Ok(_service.DeleteUser(username));
        }
    }
}