using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Services.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace MusicAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumsController : ControllerBase
    {
        private IWebHostEnvironment webHostEnvironment;
        private IConfiguration _configuration;
        private AlbumsService _service;

        public AlbumsController(IWebHostEnvironment env, IConfiguration configuration, AlbumsService service)
        {
            webHostEnvironment = env;

            _configuration = configuration;
            _service = service;

        }
        [Route("getall")]
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_service.GetAll());
        }

    }
}