using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Models.Models;
using Data.Services.Dto;
using Data.Services.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace MusicAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenresController : ControllerBase
    {
        private IWebHostEnvironment webHostEnvironment;
        private IConfiguration _configuration;
        private GenresService _service;

        public GenresController(IWebHostEnvironment env, IConfiguration configuration, GenresService service)
        {
            webHostEnvironment = env;

            _configuration = configuration;
            _service = service;

        }
        [Route("getall")]
        [HttpGet]
        public IActionResult GetAll (string order,bool decending)
        {
            return Ok(_service.GetAll(order,decending));
        }
        [HttpPost]
        public IActionResult AddGenre([FromQuery] GenrePost  genre)
        {
            _service.AddGenre(genre);
            return Ok(genre);
        }
        [Route("updategenre")]
        [HttpPost]
        public IActionResult UpdateGenre(string name, GenrePost genre)
        {
            _service.UpdateGenre(name, genre);
            return Ok(genre);
        }

    }
}