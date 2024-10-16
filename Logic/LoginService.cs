using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class LoginService
    {
        private LoginDAO loginDAO;
        private EncryptionService encryptionService;
        public LoginService() 
        { 
            loginDAO = new LoginDAO();
            encryptionService = new EncryptionService();
        }

        // Check the login
        public Employee checkLogin(string username, string password)
        {
            try
            {
                Employee employee = loginDAO.GetUserByID(username);
                string encryptedPassword = encryptionService.EncryptPassword(password, employee.Salt);
                if (employee.HashedPassword == encryptedPassword)
                {
                    return employee;
                }
                else
                {
                    throw new Exception("Invalid username or password");
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }


    }
}
