using Model;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

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


        public void DeleteEmployee(string id)
        {
            GetEmployeeCollection().DeleteOne(id);
        }
    }
}
