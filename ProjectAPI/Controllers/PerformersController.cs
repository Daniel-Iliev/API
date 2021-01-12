using System;
using System.Collections.Generic;
using System.Linq;
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
    public class PerformersController : ControllerBase
    {
        private IWebHostEnvironment webHostEnvironment;
        private IConfiguration _configuration;
        private PerformersService _service;

        public PerformersController(IWebHostEnvironment env, IConfiguration configuration,PerformersService service)
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
        [HttpPost]
        public IActionResult AddPerformer([FromQuery] PerformerPost performer)
        {
            _service.AddPerformer(performer);
            return Ok(performer);
        }
        [Authorize]
        [Route("updateperformer")]
        [HttpPost]
        public IActionResult UpdatePerformer(string name, PerformerPost performer)
        {
            _service.UpdatePerformer(name, performer);
            return Ok(performer);
        }
    }
}