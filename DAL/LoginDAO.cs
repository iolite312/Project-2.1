using Model;
using Model.Enums;
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
