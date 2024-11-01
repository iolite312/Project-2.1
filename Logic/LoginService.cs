using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Net.NetworkInformation;
using System.CodeDom;

namespace Logic
{
    public class LoginService
    {
        private LoginDAO loginDAO;
        private EncryptionService encryptionService;
        private string fileName = "RememberMe";
        private int tokenLenght = 64;
        public LoginService() 
        { 
            loginDAO = new LoginDAO();
            encryptionService = new EncryptionService();
        }

        // Check the login
        public Employee checkLogin(string email, string password)
        {
            try
            {
                Employee employee = loginDAO.GetUserByEmail(email);
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

        //Save the login details id remember me is used
        public void SaveLoginDetails(string email, string password)
        {
            RememberMeService rememberMeService = new RememberMeService();
            byte[] Key = encryptionService.GenerateRandomKey(32);
            byte[] IV = encryptionService.GenerateRandomIV();
            RememberMe rememberMeSave = new RememberMe(encryptionService.Encrypt(email,Key,IV), encryptionService.Encrypt(password,Key,IV), rememberMeService.GetMacAddress(), Key, rememberMeService.GetProcessorId(), IV, rememberMeService.GetDiskDriveId(), DateTime.Now);
            rememberMeService.SaveRememberMeData(rememberMeSave);
        }
    }
}
