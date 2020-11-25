using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace MusicAPI.Controllers
{
    [Route("api/[controller]")] 
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IWebHostEnvironment webHostEnvironment;
        private IConfiguration _configuration;
        public ProductsController(IWebHostEnvironment env, IConfiguration configuration)
        {
            webHostEnvironment = env;

            _configuration = configuration;
        }
        //[Authorize]
        [HttpGet]
        public IActionResult GetAll()
        {
            var res = _configuration.GetSection("Test").Value;
            return Ok(res);
        }
        [Route("getfirst")]
        [HttpGet]
        public IActionResult GetFirst()
        {
            return Ok("first");
        }

    }
}