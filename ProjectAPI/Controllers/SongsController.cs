using Microsoft.AspNetCore.Mvc;
using Data.Services.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Data.Services.Dto;
using Microsoft.AspNetCore.Authorization;

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
        public IActionResult GetAll(string order, bool decending)
        {
            return Ok(_service.GetAll(order, decending));
        }
        [Route("getsongsofbyyear")]
        [HttpGet]
        public IActionResult GetSongsOfByYear(string perfName, int year)
        {
            return Ok(_service.GetSongsOfByYear(perfName, year));
        }
        [Authorize]
        [HttpPost]
        public IActionResult AddSong([FromQuery] SongPost song)
        {
            _service.AddSong(song);
            return Ok(song);
        }
        [Authorize]
        [Route("updatesong")]
        [HttpPost]
        public IActionResult UpdateSong(string name, SongPost song)
        {
            _service.UpdateSong(name, song);
            return Ok(song);
        }
        
            [Authorize(Roles = "Admin")]
            [Route("deletesong")]
            [HttpDelete]
            public IActionResult DeleteSong(string name)
            {

                return Ok(_service.DeleteSong(name));
            }
        
    }
}