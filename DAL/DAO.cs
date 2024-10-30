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
        protected IMongoCollection<Employee> GetEmployeeCollection()
        {
            return db.GetCollection<Employee>("employees");
        }
        protected IMongoCollection<Ticket> GetTicketCollection()
        {
            return db.GetCollection<Ticket>("tickets");
        }
    }


}
