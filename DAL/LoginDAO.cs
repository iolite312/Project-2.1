using Model;
using MongoDB.Driver;
using System;
using System.Linq;

namespace DAL
{
    public class LoginDAO : DAO
    {
        public Employee GetUserByEmail(string email)
        {
            Employee newEmployee = GetEmployeeCollection().Find(employee => employee.Email == email).FirstOrDefault();
            if (newEmployee == null)
            {
                throw new Exception("Invalid username or password!");
            }
            return newEmployee; 
        }
    }
}
