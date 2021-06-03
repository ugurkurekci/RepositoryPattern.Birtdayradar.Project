using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BirthDayController : ControllerBase
    {
        IBirthDayService _birthDayService;

        public BirthDayController(IBirthDayService birthDayService)
        {
            _birthDayService = birthDayService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _birthDayService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(BirthDayRadar birthDayRadar)
        {
            var result = _birthDayService.Add(birthDayRadar);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }
    }
}
