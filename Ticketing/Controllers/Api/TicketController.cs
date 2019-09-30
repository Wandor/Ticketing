using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ticketing.Data;
using Ticketing.Models;
namespace Ticketing.Controllers.Api
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TicketController(ApplicationDbContext context)
        {
            _context = context;
        }

        //GET : Api/Ticket
        [HttpGet("TicketID")]
        public IActionResult GetTicket([FromRoute] Guid TicketID)
        {
            return Ok(new { data = _context.Tickets.Where(x => x.TicketID.Equals(TicketID)).ToList() });
        }

    }
}