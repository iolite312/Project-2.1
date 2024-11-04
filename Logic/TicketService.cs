using DAL;
using Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Logic
{
    public class TicketService
    {
        private TicketDAO ticketDAO;

        public TicketService()
        {
            ticketDAO = new TicketDAO();
        }

        public void CreateTicket(Ticket ticket)
        {
            ticketDAO.CreateTicket(ticket);
        }

        public List<Ticket> GetTickets()
        {
            return ticketDAO.GetTickets();
        }

        public List<Ticket> GetEmployeeTickets(string id)
        {
            return ticketDAO.GetEmployeeTickets(id);
        }
        public List<Ticket> GetHandlerTickets(string id)
        {
            return ticketDAO.GetHandlerTickets(id);
        }

        public Ticket GetTicket(string id)
        {
            return ticketDAO.GetTicket(id);
        }

        public void UpdateTicket(Ticket ticket)
        {
            ticketDAO.UpdateTicket(ticket);
        }

        public Task<bool> DeleteTicket(string id) 
        { 
            return ticketDAO.DeleteTicket(id);
        }
        public List<Handler> AllHandlers()
        {
            return ticketDAO.GetHandlers();
        }

        public List<Ticket> GetTicketsByMatchOr(List<string> keywords)
        {
            return ticketDAO.GetTicketsByMatchOr(keywords);
        }

        public List<Ticket> GetTicketsByMatchAnd(List<string> keywords)
        {
            return ticketDAO.GetTicketsByMatchAnd(keywords);
        }
    }
}
