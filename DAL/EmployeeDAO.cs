using Model;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model.Enums;
using System;
using System.Net.Sockets;

namespace DAL
{
    public class EmployeeDAO : DAO
    {
        public void CreateEmployee(Employee employee)
        {
            GetEmployeeCollection().InsertOne(employee);
        }

        public List<Employee> GetEmployees()
        {
            PipelineDefinition<Employee, Employee> filter = new BsonDocument[]
            {
                new BsonDocument("$sort",
                new BsonDocument
                    {
                        { "Department", 1 },
                        { "LastName", 1 }
                    })
            };
            return GetEmployeeCollection().Aggregate(filter).ToList();
        }

        public Employee GetEmployee(string id)
        {
            return GetEmployeeCollection().Find(employee => employee.Id == id).First();
        }

        public void UpdateEmployee(Employee employee)
        {
            FilterDefinition<Employee> filter = Builders<Employee>.Filter.Eq(e => e.Id, employee.Id);

            UpdateDefinition<Employee> updateDefinition = Builders<Employee>.Update
                .Set(e => e.FirstName, employee.FirstName)
                .Set(e => e.LastName, employee.LastName)
                .Set(e => e.Email, employee.Email)
                .Set(e => e.PhoneNumber, employee.PhoneNumber)
                .Set(e => e.Role, employee.Role)
                .Set(e => e.Salt, employee.Salt)
                .Set(e => e.HashedPassword, employee.HashedPassword)
                .Set(e => e.Department, employee.Department);

            GetEmployeeCollection().FindOneAndUpdate(filter, updateDefinition);

            FilterDefinition<Ticket> ticketdef = Builders<Ticket>.Filter.Eq("EmployeeEID._id", employee.Id);

            PipelineDefinition<Ticket, Ticket> pipelineDefinition = new BsonDocument[]
            {
                new BsonDocument("$set",
                new BsonDocument
                    {
                        { "EmployeeEID.FirstName", employee.FirstName },
                        { "EmployeeEID.LastName", employee.LastName },
                        { "EmployeeEID.Email", employee.Email },
                        { "EmployeeEID.Role", employee.Role },
                        { "EmployeeEID.Department", employee.Department }
                    })
            };

            if (employee.Role == ERole.ServiceDesk)
            {
                ticketdef = Builders<Ticket>.Filter.Eq("HandlerEID._id", employee.Id);
                pipelineDefinition = new BsonDocument[]
                {
                    new BsonDocument("$set",
                    new BsonDocument
                        {
                            { "HandlerEID.FirstName", employee.FirstName },
                            { "HandlerEID.LastName", employee.LastName },
                        })
                };
            }

            GetTicketCollection().UpdateMany(ticketdef, pipelineDefinition);
        }


        public async Task<bool> DeleteEmployee(Employee employee)
        {
            ObjectId objectId = new ObjectId(employee.Id);
            FilterDefinition<Employee> filterDefinition = Builders<Employee>.Filter.Eq("_id", objectId);
            DeleteResult result = await GetEmployeeCollection().DeleteOneAsync(filterDefinition);

            if (result.DeletedCount > 0)
            {
                return true;
            }
            return false;
        }
    }
}
