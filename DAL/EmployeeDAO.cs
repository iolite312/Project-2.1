using Model;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            return GetEmployeeCollection().Find(_ => true).ToList();
        }

        public Employee GetEmployee(string id)
        {
            return GetEmployeeCollection().Find(employee => employee.Id == id).First();
        }

        public void UpdateEmployee(Employee employee)
        {
            FilterDefinition<Employee> filter = Builders<Employee>.Filter.Eq(e => e.Id, employee.Id);

            UpdateDefinition<Employee> updateDefinition = Builders<Employee>.Update
                .Set(e => e.Email, employee.Email)
                .Set(e => e.PhoneNumber, employee.PhoneNumber)
                .Set(e => e.Role, employee.Role)
                .Set(e => e.Salt, employee.Salt)
                .Set(e => e.HashedPassword, employee.HashedPassword)
                .Set(e => e.Department, employee.Department);

            GetEmployeeCollection().FindOneAndUpdate(filter, updateDefinition);
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
