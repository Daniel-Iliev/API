﻿using Microsoft.AspNetCore.Mvc;
using Data.Services.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace MusicAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongsController : ControllerBase
    {
        private IWebHostEnvironment webHostEnvironment;
        private IConfiguration _configuration;
        private SongsService _service;

        public SongsController(IWebHostEnvironment env, IConfiguration configuration, SongsService service)
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
        [Route("getfirst")]
        [HttpGet]
        public IActionResult GetFirst()
        {
            return Ok("first");
        }
       
    }
}