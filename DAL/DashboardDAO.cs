using Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using Model;

namespace DAL
{
    public class DashboardDAO : DAO
    {
        public int CountAllOpenTickets()
        {
            List<Ticket> tickets = GetTicketCollection().Find(ticket => ticket.Status == ETicketStatus.Open).ToList();
            return tickets.Count;
        }
        public int CountAllTickets()
        {
            // Verkrijg de collectie van tickets
            List<Ticket> tickets = GetTicketCollection().Find(ticket => ticket.Status != null).ToList();
            return tickets.Count;
        }
    }
}
