using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Models.Models;
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
    public class GenresController : ControllerBase
    {
        private GenresService _service;

        public GenresController( GenresService service)
        {
            _service = service;

        }
        [Authorize]
        [Route("getall")]
        [HttpGet]
        public IActionResult GetAll (string order,bool descending)
        {
            return Ok(_service.GetAll(order,descending));
        }
        [Route("addgenre")]
        [Authorize(Roles = "Moderator, Admin")]
        [HttpPost]
        public IActionResult AddGenre(GenrePost  genre)
        {
            return Ok(_service.AddGenre(genre));
        }
        [Authorize(Roles = "Moderator, Admin")]
        [Route("updategenre")]
        [HttpPost]
        public IActionResult UpdateGenre(string name, GenrePost genre)
        {
            return Ok(_service.UpdateGenre(name,genre));
        }
        
        [Authorize(Roles = "Moderator, Admin")]
        [Route("deletegenre")]
        [HttpDelete]
        public IActionResult DeleteGenre(string genreName)
        {
            
            return Ok(_service.DeleteGenre(genreName));
        }
    }
}