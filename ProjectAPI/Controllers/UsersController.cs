﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    public class UsersController : ControllerBase
    {
        private IWebHostEnvironment webHostEnvironment;
        private IConfiguration _configuration;
        private UsersService _service;

        public UsersController(IWebHostEnvironment env, IConfiguration configuration, UsersService service)
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
        [Route("addfav")]
        [HttpPost]
        public IActionResult AddFavourite(FavouritePost favouritePost)
        {
            _service.AddFavourite(favouritePost);
            return Ok(favouritePost);
        }
        [Route("changeusername")]
        [HttpPost]
        public IActionResult ChangeUsername(string name, UserPost user)
        {
            _service.ChangeUsername(name, user);
            return Ok(user);
        }

    }
}