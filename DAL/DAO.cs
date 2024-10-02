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

        public List<Databases_Model> GetDatabases()
        {
            List<Databases_Model> all_databases = new List<Databases_Model>();

            foreach (BsonDocument db in client.ListDatabases().ToList())
            {
                all_databases.Add(BsonSerializer.Deserialize<Databases_Model>(db));
            }
            return all_databases;
        }
        public List<Ticket> GetTickets()
        {
            // Get the "tickets" collection from the "Project" database
            List<Ticket> tickets = db.GetCollection<Ticket>("tickets").Find(_ => true).ToList();

            // Query all documents in the collection and retrieve them as a list
             //ticketCollection;
            return tickets;
        }
    }


}
