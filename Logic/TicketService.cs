﻿using DAL;
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

        public Ticket GetTicket(string id)
        {
            return ticketDAO.GetTicket(id);
        }

        public void UpdateTicket(Ticket ticket)
        {
            ticketDAO.UpdateTicket(ticket);
        }

        public Task<bool> DeleteTicket(Ticket ticket) 
        { 
            return ticketDAO.DeleteTicket(ticket);
        }
    }
}