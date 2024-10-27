using Model;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Threading.Tasks;

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
            PipelineDefinition<Ticket, Ticket> filter = new BsonDocument[] {
                new BsonDocument("$sort",
                new BsonDocument
                    {
                        { "TimeStamp", 1 },
                        { "Status", 1 }
                    })
            };
            return GetTicketCollection().Aggregate(filter).ToList();
        }

        public List<Ticket> GetEmployeeTickets(string id)
        {
            // in this aggregation the $or statement is purely here for compatability sake because C# inserts models in to mongodb differently the mongodb Compass
            PipelineDefinition<Ticket, Ticket> filter = new BsonDocument[]
            {
                new BsonDocument("$match",
                new BsonDocument("$or",
                new BsonArray
                        {
                            new BsonDocument("EmployeeEID._id", id),
                            new BsonDocument("EmployeeEID._id",
                            new ObjectId(id))
                        }))
            };
            return GetTicketCollection().Aggregate(filter).ToList();
        }

        public List<Ticket> GetHandlerTickets(string id)
        {
            // in this aggregation the or statement is purely here for compatability sake because C# inserts models in to mongodb differently the mongodb Compass
            PipelineDefinition<Ticket, Ticket> filter = new BsonDocument[]
            {
                new BsonDocument("$match",
                new BsonDocument("$or",
                new BsonArray
                        {
                            new BsonDocument("HandlerEID._id", id),
                            new BsonDocument("HandlerEID._id",
                            new ObjectId(id))
                        }))
            };
            return GetTicketCollection().Aggregate(filter).ToList();
        }

        public Ticket GetTicket(string id)
        {
            Ticket ticket = GetTicketCollection().Find(ticket => ticket.Id == id).FirstOrDefault();
            if (ticket != null) 
            { 
                return ticket;
            }
            throw new ArgumentNullException("Ticket does not exist");
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

        public async Task<bool> DeleteTicket(string id)
        {
            ObjectId objectId = new ObjectId(id);
            FilterDefinition<Ticket> filterDefinition = Builders<Ticket>.Filter.Eq("_id", objectId);
            PipelineDefinition<Ticket, Ticket> pipelineDefinition = new BsonDocument[]
            {
                new BsonDocument("$set",
                new BsonDocument("Status", 2))
            };
            UpdateResult result = await GetTicketCollection().UpdateOneAsync(filterDefinition, pipelineDefinition);

            if (result.ModifiedCount > 0)
            {
                return true;
            }
            return false;
        }
    }
}
