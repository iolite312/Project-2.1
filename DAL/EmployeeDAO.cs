using Model;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model.Enums;
using System;

namespace DAL
{
    public class EmployeeDAO : DAO
    {
        public bool CreateEmployee(Employee employee)
        {
            if (GetEmployeeCollection().Find(e => e.Email == employee.Email).FirstOrDefault() != null) 
            {
                return false;
            }
            GetEmployeeCollection().InsertOne(employee);
            return true;
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
            Employee em = GetEmployeeCollection().Find(employee => employee.Id == id).FirstOrDefault();
            if (em != null)
            {
                return em;
            }
            throw new ArgumentNullException("User does not exist");
        }

        public void UpdateEmployee(Employee employee)
        {
            if (GetEmployee(employee.Id) == null) { return; }

            FilterDefinition<Employee> filter = Builders<Employee>.Filter.Eq(e => e.Id, employee.Id);

            UpdateDefinition<Employee> updateDefinition = Builders<Employee>.Update
                .Set(e => e.FirstName, employee.FirstName)
                .Set(e => e.LastName, employee.LastName)
                .Set(e => e.Email, employee.Email)
                .Set(e => e.PhoneNumber, employee.PhoneNumber)
                .Set(e => e.Role, employee.Role)
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


        public async Task<bool> DeleteEmployee(string id)
        {
            ObjectId objectId = new ObjectId(id);
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
