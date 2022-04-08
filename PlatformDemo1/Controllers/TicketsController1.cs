using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlatformDemo1.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // Generalized routing attribute
    public class TicketsController : ControllerBase
    {
        [HttpGet]

        public IActionResult Get()
        {
            return Ok("Reading all the ticket");
        }
        [HttpGet("{id}")]

        public IActionResult GetById(int id)
        {
            return Ok($"Reading ticket with ID #{id}.");
        }
        [HttpPost]
        public IActionResult Post([FromBody] TicketsController ticket)
        {
            return Ok( ticket);
        }
        [HttpPut]

        public IActionResult Put([FromBody] TicketsController ticket)
        {
            return Ok( ticket);
        }
        [HttpDelete("{id}")]

        public IActionResult Delete(int id)
        {
            return Ok($"Deleting ticket with #{id}.");
        }

    } 
}
