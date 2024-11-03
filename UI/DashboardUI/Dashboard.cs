using Logic;
using Model;
using Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace UI.DashboardUI
{
    public partial class Dashboard : Form
    {
        
        
        protected int AllTickets;
        private Employee _employee;
        protected int closedTickets;
        protected int openTickets;
        protected int resolvedTickets;
        public Dashboard(Employee employee)
        {
            _employee = employee;
            List<Ticket> allTickets = new List<Ticket>(); ;

            TicketService service = new TicketService();
            if (_employee.Role == ERole.Employee)
            {
                allTickets = service.GetEmployeeTickets(_employee.Id);
            }
            else
            {
                allTickets = service.GetTickets();
            }
            AllTickets =CountAllTickets(allTickets);
            openTickets = CalculateStatusTickets(allTickets, ETicketStatus.Open);
            resolvedTickets = CalculateStatusTickets(allTickets, ETicketStatus.Resolved);
            closedTickets = CalculateStatusTickets(allTickets, ETicketStatus.Closed);           
            InitializeComponent();
        }    
        private void showListBtn_Click(object sender, EventArgs e)
        {
            TicketUI.TicketUI ticketUI = new TicketUI.TicketUI(_employee);
            ticketUI.Show();
            this.Hide();
        }
        private int CalculateStatusTickets(List<Ticket> allTickets, ETicketStatus status)
        {
            int countOfTickets=0;
            foreach (Ticket ticket in allTickets)
            {
                if (ticket.Status == status) countOfTickets++;
            }
            return countOfTickets;
        }

        private int CountAllTickets(List<Ticket> allTickets)
        {
             return allTickets.Count ;
        }

        private List<Ticket> filterTickets(Employee employee , List<Ticket> allTickets)
        {
            if (employee.Role != ERole.ServiceDesk)
            {List<Ticket> list = new List<Ticket>();
                foreach (Ticket ticket in allTickets)
                {
                    if (employee.Email != ticket.Employee.Email) list.Add(ticket);
                }
                foreach(Ticket ticket in list)
                {
                    allTickets.Remove(ticket);
                }
            }
            return allTickets;
        }
    }
}
