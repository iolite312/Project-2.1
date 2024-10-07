using Model;
using Model.Enums;
using MongoDB.Bson;
using MongoDB.Driver;
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
            List<Ticket> tickets = GetDBConnection().GetCollection<Ticket>("tickets").Find(ticket => ticket.Status == ETicketStatus.Open).ToList();
        }

        public Employee GetUserByID(string username)
        {
            return GetDBConnection().GetCollection<Employee>("employees").Find(employee => employee.Id == username);
        }
    }
}
