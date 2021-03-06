﻿using System;
using Data.Models.Models;
using Data.Services.Dto;
using Data.Services.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace MusicAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumsController : ControllerBase
    {
        private AlbumsService _service;

        public AlbumsController( AlbumsService service)
        {
            _service = service;

        }
        [Authorize]
        [Route("getall")]
        [HttpGet]
        public IActionResult GetAll(string order,bool descending)
        {
            return Ok(_service.GetAll(order,descending));
        }
        [Route("addalbum")]
        [Authorize(Roles = "Moderator, Admin")]
        [HttpPost]
        public IActionResult AddAlbum(AlbumPost album)
        {
            return Ok(_service.AddAlbum(album));
        }
        [Authorize(Roles = "Moderator, Admin")]
        [Route("addalbumgenre")]
        [HttpPost]
        public IActionResult AddAlbumGenre(AlbumGenrePost albumGenrePost)
        {
            return Ok(_service.AddAlbumGenre(albumGenrePost));
        }
        [Authorize(Roles = "Moderator, Admin")]
        [Route("updatealbum")]
        [HttpPost]
        public IActionResult Updatealbum(string name, AlbumPost album)
        {
            return Ok(_service.UpdateAlbum(name,album));
        }
        [Authorize(Roles = "Moderator, Admin")]
        [Route("deletealbum")]
        [HttpDelete]
        public IActionResult DeleteAlbum(string albumName)
        {
            
            return Ok(_service.DeleteAlbum(albumName));
        }

        [Authorize(Roles = "Moderator, Admin")]
        [Route("deletealbumgenre")]
        [HttpDelete]
        public IActionResult DeleteAlbumGenre(string albumName,string genreName)
        {

            return Ok(_service.DeleteAlbumGenre(albumName,genreName));
        }
    }
}