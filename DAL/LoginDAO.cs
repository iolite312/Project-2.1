using Model;
using Model.Enums;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoginDAO : DAO
    {
        public Employee GetUserByID(string username)
        {
            Employee newEmployee = (Employee)GetEmployeeCollection().Find(employee => employee.FirstName == username).FirstOrDefault();
            if (newEmployee == null)
            {
                throw new Exception("Invalid username or password!");
            }
            return newEmployee; 
        }
    }
}
