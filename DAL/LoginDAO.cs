using Model;
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
        public void Test()
        {
            List<Ticket> tickets = GetDBConnection().GetCollection<Ticket>("tickets").Find(ticket => ticket.Status == "Open").ToList();
        }
    }
}
