using Api.DTO;
using Api.Identity;
using Logic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using Model.Enums;

namespace Api.Controllers
{
    [Authorize]
    [Route("api/ticket")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly TicketService _ticketService;

        public TicketController()
        {
            _ticketService = new TicketService();
        }

        [HttpGet("all")]
        [RequiresClaim("rolePermissions", ERole.ServiceDesk, ERole.Manager)]
        public IActionResult GetAllTickets()
        {
            List<Ticket> tickets = _ticketService.GetTickets();
            return Ok(tickets);
        }

        [HttpGet("employee/{employeeId}")]
        public IActionResult GetTicketsFromEmployee([FromRoute] string employeeId)
        {
            List<Ticket> tickets = _ticketService.GetEmployeeTickets(employeeId);
            return Ok(tickets);
        }

        [HttpGet("handler/{handlerId}")]
        [RequiresClaim("rolePermissions", ERole.ServiceDesk, ERole.Manager)]
        public IActionResult GetTicketsFromHandler([FromRoute] string handlerId)
        {
            List<Ticket> tickets = _ticketService.GetHandlerTickets(handlerId);
            return Ok(tickets);
        }

        [HttpPost("create")]
        public IActionResult Create([FromBody] TicketDTO ticket)
        {
            Ticket tickets = ticket.RevertModel();
            _ticketService.CreateTicket(tickets);
            Response.StatusCode = 201;
            return new JsonResult(new { message = "Ticket has been created" });
        }

        [HttpGet("{id}")]
        [RequiresClaim("rolePermissions", ERole.ServiceDesk, ERole.Manager)]
        public IActionResult GetTicket([FromRoute] string id) 
        { 
            Ticket ticket = _ticketService.GetTicket(id);
            return Ok(ticket);
        }

        [HttpPut("{id}/update")]
        [RequiresClaim("rolePermissions", ERole.ServiceDesk, ERole.Manager)]
        public IActionResult Update([FromRoute] string id, [FromBody] TicketDTO ticket)
        {
            try
            {
                _ticketService.UpdateTicket(ticket.RevertModel(id));
                return Ok(ticket);
            }
            catch (ArgumentNullException)
            {
                Response.StatusCode = 404;
                return new JsonResult(new { message = "Ticket not found or does not exist" });
            }
            catch (Exception)
            {
                Response.StatusCode = 500;
                return new JsonResult(new { message = "Internal Server Error" });
            }
        }

        [HttpDelete("{id}/close")]
        [RequiresClaim("rolePermissions", ERole.ServiceDesk, ERole.Manager)]
        public IActionResult Delete([FromRoute] string id)
        {
            try
            {
                bool isSuccesful = _ticketService.DeleteTicket(id).Result;

                if (isSuccesful)
                {
                    Response.StatusCode = 200;
                    return new JsonResult(new { message = "Ticket was closed" });
                }
                Response.StatusCode = 404;
                return new JsonResult(new { message = "Ticket not found or does not exist" });
            }
            catch (Exception)
            {
                Response.StatusCode = 500;
                return new JsonResult(new { message = "Internal Server Error" });
            }
        }
    }
}
