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
        private SongsService _service;

        public SongsController(SongsService service)
        {
            _service = service;

        }
        [Authorize]
        [Route("getall")]
        [HttpGet]
        public IActionResult GetAll(string order, bool descending)
        {
            return Ok(_service.GetAll(order, descending));
        }
        [Authorize]
        [Route("getsongsofbyyear")]
        [HttpGet]
        public IActionResult GetSongsOfByYear(string perfName, int year)
        {
            return Ok(_service.GetSongsOfByYear(perfName, year));
        }
        [Route("addsong")]
        [Authorize(Roles = "Moderator, Admin")]
        [HttpPost]
        public IActionResult AddSong(SongPost song)
        {
            return Ok(_service.AddSong(song));
        }
        [Authorize(Roles = "Moderator, Admin")]
        [Route("updatesong")]
        [HttpPost]
        public IActionResult UpdateSong(string name, SongPost song)
        {
            return Ok(_service.UpdateSong(name,song));
        }
        
        [Authorize(Roles = "Moderator, Admin")]
        [Route("deletesong")]
        [HttpDelete]
        public IActionResult DeleteSong(string songName)
        {

            return Ok(_service.DeleteSong(songName));
        }
       
    }
}