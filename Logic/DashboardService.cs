using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class DashboardService
    {
        DashboardDAO dashboardDAO;
        public DashboardService()
        {
            dashboardDAO = new DashboardDAO();  
        }
        public List<Ticket> AllTickets() 
        {
            return dashboardDAO.GetAllTickets();
        }
    }
}
