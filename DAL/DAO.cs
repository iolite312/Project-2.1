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
            client = new MongoClient("<Put your own mongoDB instance url here>");
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
