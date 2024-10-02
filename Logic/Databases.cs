using DAL;
using Model;
using System.Collections.Generic;

namespace Logic
{
    public class Databases
    {
        private LoginDAO dao;
        public Databases()
        {
            dao = new LoginDAO();
        }

        public void Get_All_Databases()
        {
            dao.Test();
        }
    }
}
