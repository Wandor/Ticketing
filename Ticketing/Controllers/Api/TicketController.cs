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
        // GET: api/Ticket/Customer
        [HttpGet("Customer/{customerId}")]
        public IActionResult GetTicketCustomer([FromRoute]Guid CustomerID)
        {
            return Ok(new { data = _context.Tickets.Where(x => x.CustomerID.Equals(CustomerID)).ToList() });
        }

        // POST: api/Ticket
        [HttpPost]
        public async Task<IActionResult> PostTicket([FromBody] Ticket ticket)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                if (ticket.TicketID == Guid.Empty)
                {
                    //Contact contact = _context.Contact.Where(x => x.contactId.Equals(ticket.contactId)).FirstOrDefault();
                    ticket.TicketID = Guid.NewGuid();
                    ticket.CustomerID = contact.customerId;
                    _context.Tickets.Add(ticket);

                    await _context.SaveChangesAsync();

                    return Ok(new { success = true, message = "Add new data success." });
                }
                else
                {
                    _context.Update(ticket);

                    await _context.SaveChangesAsync();

                    return Ok(new { success = true, message = "Edit data success." });
                }
            }
            catch (Exception ex)
            {

                return Ok(new { success = false, message = ex.Message });
            }


        }
    }
}