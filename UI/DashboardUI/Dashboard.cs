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
using UI.CreateTicket;



namespace UI.DashboardUI
{
    public partial class Dashboard : Form
    {
        protected int AllTickets;
        private Employee _employee;
        protected int closedTickets;
        protected int openTickets;
        protected int resolvedTickets;
        private List<Ticket> _allTickets = new List<Ticket>();
        public Dashboard(Employee employee)
        {
            _employee = employee;

            TicketService service = new TicketService();
            if (_employee.Role == ERole.Employee)
            {
                _allTickets = service.GetEmployeeTickets(_employee.Id);
                employeeListBtn.Enabled = false;
                employeeListBtn.Hide();
            }
            else
            {
                _allTickets = service.GetTickets();
            }
            AllTickets = CountAllTickets(_allTickets);
            openTickets = CalculateStatusTickets(_allTickets, ETicketStatus.Open);
            resolvedTickets = CalculateStatusTickets(_allTickets, ETicketStatus.Resolved);
            closedTickets = CalculateStatusTickets(_allTickets, ETicketStatus.Closed);
            InitializeComponent();
        }
        private void showListBtn_Click(object sender, EventArgs e)
        {
            subViewPanel.Visible = true;
            subViewPanel.Controls.Clear();
            EmployeeUI.EmployeeUIctl employeeUI = new EmployeeUI.EmployeeUIctl();
            subViewPanel.Controls.Add(employeeUI);
            this.Width = 1300;
            this.Height = 800;
        }
        private int CalculateStatusTickets(List<Ticket> allTickets, ETicketStatus status)
        {
            int countOfTickets = 0;
            foreach (Ticket ticket in allTickets)
            {
                if (ticket.Status == status) countOfTickets++;
            }
            return countOfTickets;
        }

        private int CountAllTickets(List<Ticket> allTickets)
        {
            return allTickets.Count;
        }

        private List<Ticket> filterTickets(Employee employee, List<Ticket> allTickets)
        {
            if (employee.Role != ERole.ServiceDesk)
            {
                List<Ticket> list = new List<Ticket>();
                foreach (Ticket ticket in allTickets)
                {
                    if (employee.Email != ticket.Employee.Email) list.Add(ticket);
                }
                foreach (Ticket ticket in list)
                {
                    allTickets.Remove(ticket);
                }
            }
            return allTickets;
        }

        private void ticketsListBtn_Click(object sender, EventArgs e)
        {
            subViewPanel.Visible = true;
            subViewPanel.Controls.Clear();
            TicketUI.TicketUIctl ticketUI = new TicketUI.TicketUIctl(_allTickets, _employee);
            subViewPanel.Controls.Add(ticketUI);
            this.Width = 1200;
            this.Height = 800;
        }

        private void dashBoardBtn_Click(object sender, EventArgs e)
        {
            subViewPanel.Visible = false;
            subViewPanel.Controls.Clear();
            this.Width = 979;
            this.Height = 630;
        }

        private void createTicketBtn_Click(object sender, EventArgs e)
        {
            CreateTicketUI createTicketUI = new CreateTicketUI(_employee);
            createTicketUI.ShowDialog();
        }
    }
}
