using System;
using Data.Models.Models;
using Data.Services.Dto;
using Data.Services.Services;
using Microsoft.AspNetCore.Hosting;
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
        public IActionResult GetAll(string order,bool decending)
        {
            return Ok(_service.GetAll(order,decending));
        }
        [HttpPost]
        public IActionResult AddAlbum([FromQuery] AlbumPost album)
        {
             _service.AddAlbum(album);
            return Ok(album);
        }
        [Route("addalbumgenre")]
        [HttpPost]
        public IActionResult AddAlbumGenre(AlbumGenrePost albumGenrePost)
        {
            _service.AddAlbumGenre( albumGenrePost);
            return Ok(albumGenrePost);
        }
        [Route("updatealbum")]
        [HttpPost]
        public IActionResult Updatealbum(string name, AlbumPost album)
        {
            _service.UpdateAlbum(name, album);
            return Ok(album);
        }
    }
}