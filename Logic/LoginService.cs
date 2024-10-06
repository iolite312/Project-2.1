using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    internal class LoginService
    {
        LoginDAO loginDAO;
        public LoginService() 
        { 
            loginDAO = new LoginDAO();
        }

        public Employee checkLogin(string username, string password)
        {
            try
            {
                loginDao.GetPassWordbyID(username);
                string encryptedPassword = EncryptPassword(password);
                Employee employee = loginDao.GetPassWordbyID(username);
                if (employee.password == encryptedPassword)
                {
                    return employee;
                }
                else
                {
                    throw new Exception("Verkeerde gebruikersnaam of wachtwoord");
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }


    }
}
