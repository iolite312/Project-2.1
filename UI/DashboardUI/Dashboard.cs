﻿using Logic;
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
        
        
        public int AllTickets;
        
        public Dashboard(Employee employee)
        {
            List<Ticket> allTickets = new List<Ticket>(); ;

            TicketService service = new TicketService();
            allTickets = service.GetTickets();
            allTickets=filterTickets(employee,allTickets);
            AllTickets=CountAllTickets(allTickets);
            int countOfOpenTickets = CalculateStatusTickets(allTickets, ETicketStatus.Open);
            int countOfResolvedTickets = CalculateStatusTickets(allTickets, ETicketStatus.Resolved);
            int countOfClosedTickets = CalculateStatusTickets(allTickets, ETicketStatus.Closed);
            
            InitializeComponent(countOfOpenTickets,countOfResolvedTickets,countOfClosedTickets);
        }    
        private void showListBtn_Click(object sender, EventArgs e)
        {
            TicketUI.TicketUI ticketUI = new TicketUI.TicketUI();
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