using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using Model;
using MongoDB.Bson.Serialization;

namespace DAL
{
    public class DAO
    {
        private MongoClient client;
        private IMongoDatabase db;

        public DAO()
        {
            client = new MongoClient("mongodb+srv://713969:GardenGroup@gardengroup.l9fpj.mongodb.net/");
            db = client.GetDatabase("Project");
        }
        protected IMongoDatabase GetDBConnection()
        {
            return db;
        }
        //public List<Ticket> GetTickets()
        //{
        //    // Get the "tickets" collection from the "Project" database
        //    List<Ticket> tickets = db.GetCollection<Ticket>("tickets").Find(ticket => ticket.Status == "Open").ToList();

        //    // Query all documents in the collection and retrieve them as a list
        //     //ticketCollection;
        //    return tickets;
        //}
    }


}
