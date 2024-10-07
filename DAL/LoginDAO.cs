using Model;
using Model.Enums;
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
            List<Ticket> tickets = GetTicketCollection().Find(ticket => ticket.Status == ETicketStatus.Open).ToList();
        }
    }
}
