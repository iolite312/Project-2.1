using Logic;
using Model;
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
        DashboardService service;
        int Opentickets;
        int AllTickets;
        int PastDeadline;
        List<Ticket> allTickets;
        public Dashboard(Employee employee)
        {
            service = new DashboardService();
            allTickets = new List<Ticket>();
            allTickets = service.AllTickets();
            filterTickets(employee);
            countAllTickets();
            calculateOpenTickets();
            pastDeadlineCounter();
            InitializeComponent();
        }    
        private void showListBtn_Click(object sender, EventArgs e)
        {

        }
        private void calculateOpenTickets()
        {
            foreach (Ticket ticket in allTickets)
            {
                if (ticket.Status == Model.Enums.ETicketStatus.Open) Opentickets++;
            }
        }
        private void countAllTickets()
        {
             AllTickets=allTickets.Count ;
        }
        private void pastDeadlineCounter()
        {
            foreach(Ticket ticket in allTickets)
            {
                TimeSpan verschil = DateTime.Now - ticket.Timestamp;
                TimeSpan deadlineSpan = TimeSpan.FromDays(ticket.Deadline*3);
                if (verschil > deadlineSpan) PastDeadline++;
            }
        }
        private void filterTickets(Employee employee)
        {
            if (employee.Role != Model.Enums.ERole.ServiceDesk)
            {
                foreach (Ticket ticket in allTickets)
                {
                    if(employee != ticket.Employee) allTickets.Remove(ticket);
                }
            }
        }
    }
}
