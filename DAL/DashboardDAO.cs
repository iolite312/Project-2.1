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
        public List<Ticket> GetAllTickets()
        {
            return GetTicketCollection().Find(ticket => ticket.Status != null).ToList();
        }
    }
}
