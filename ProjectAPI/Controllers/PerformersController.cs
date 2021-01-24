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
        private PerformersService _service;

        public PerformersController( PerformersService service)
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
        [Route("addperformer")]
        [Authorize(Roles = "Moderator, Admin")]
        [HttpPost]
        public IActionResult AddPerformer(PerformerPost performer)
        {
            return Ok(_service.AddPerformer(performer));
        }
        [Authorize(Roles = "Moderator, Admin")]
        [Route("updateperformer")]
        [HttpPost]
        public IActionResult UpdatePerformer(string name, PerformerPost performer)
        {
            return Ok(_service.UpdatePerformer(name,performer));
        }

        [Authorize(Roles = "Moderator, Admin")]
        [Route("deleteperformer")]
        [HttpDelete]
        public IActionResult DeletePerformer(string performerName)
        {

            return Ok(_service.DeletePerformer(performerName));
        }
    }
}