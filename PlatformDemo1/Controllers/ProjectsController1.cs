using Microsoft.AspNetCore.Mvc;
using PlatformDemo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlatformDemo1.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ProjectsController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Obtaining list of projects");
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok($"Selecting a particular project with ID #{id}.");
        }


        // creating an editor command
        /// <summary>
        /// api/projects/{pid}/tickets?tid={tid}
        /// </summary>
        /// <param name="pId"></param>
        /// <param name="tId"></param>
        /// <returns></returns>
       [HttpGet]
        [Route("/api/projects/{pid}/tickets")]
        public IActionResult GetProjectTicket(int pId, [FromBody] int tId)

        {
           if (tId == 0)

                return Ok($"Selecting all tickets belonging to project with ID #{pId}");
            else

                return Ok($"Selecting a project with ID #{pId} and ticket #{tId}");
        }

        // model by name to a complex data type (object=ticket)

        ///[HttpGet]
        ///[Route("/api/projects/{pid}/tickets")]
        ///public IActionResult GetProjectTicket([FromQuery]Ticket ticket)

       /// {

          ///  if (ticket == null) return BadRequest ("Parameters are not provided properly!");
            ///if (ticket.TicketId == 0)

               /// return Ok($"Selecting all tickets belonging to project with ID #{ticket.ProjectId}");
            ///else

               /// return Ok($"Selecting a project with ID #{ticket.ProjectId} and ticket #{ticket.TicketId}with tittle: {ticket.Tittle} and description {ticket.Description}");
        ///}

        [HttpPost]
        public IActionResult Post()
        {
            return Ok("Creating a project");
        }

        [HttpPut]
        public IActionResult Put()
        {
            return Ok("Updating a project.");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok($"Deleting a particular project with #{id}.");
        }

    }
}
