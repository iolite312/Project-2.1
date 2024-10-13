using Model;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class TicketDAO : DAO
    {
        public void CreateTicket(Ticket ticket)
        {
            GetTicketCollection().InsertOne(ticket);
        }

        public List<Ticket> GetTickets()
        {
            return GetTicketCollection().Find(_ => true).ToList();
        }

        public Ticket GetTicket(string id)
        {
            return GetTicketCollection().Find(ticket => ticket.Id == id).First();
        }

        public void UpdateTicket(Ticket ticket)
        {
            FilterDefinition<Ticket> filter = Builders<Ticket>.Filter.Eq(e => e.Id, ticket.Id);

            UpdateDefinition<Ticket> update = Builders<Ticket>.Update
                .Set(e => e.CaseName, ticket.CaseName)
                .Set(e => e.Type, ticket.Type)
                .Set(e => e.Status, ticket.Status)
                .Set(e => e.Description, ticket.Description)
                .Set(e => e.Timestamp, ticket.Timestamp)
                .Set(e => e.Priority, ticket.Priority)
                .Set(e => e.Handler, ticket.Handler)
                .Set(e => e.Employee, ticket.Employee)
                .Set(e => e.Deadline, ticket.Deadline);

            GetTicketCollection().FindOneAndUpdate(filter, update);
        }
        
        public void DeleteTicket(string id)
        {
            GetTicketCollection().DeleteOne(id);
        }
    }
}
