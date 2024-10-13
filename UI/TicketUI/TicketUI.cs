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

namespace UI.TicketUI
{
    public partial class TicketUI : Form
    {
        
        public TicketUI()
        {
            InitializeComponent();
            InitListView();
        }
        private void InitListView()
        {
            ticketListView.Items.Clear();
            TicketService ticketService = new TicketService();
            List<Ticket> tickets = ticketService.GetTickets();

            tickets = tickets.OrderBy(ticket => ticket.Status)
                        .ThenBy(ticket => ticket.Deadline)
                        .ToList();

            foreach (Ticket ticket in tickets)
            {
                ListViewItem item = new ListViewItem(ticket.CaseName);
                item.SubItems.Add(ticket.Type.ToString());
                item.SubItems.Add(ticket.Status.ToString());
                item.SubItems.Add(ticket.Timestamp.ToString("dd-MM-yyyy HH:mm"));
                item.SubItems.Add(ticket.Priority.ToString());
                item.SubItems.Add($"{ticket.Handler.FirstName} {ticket.Handler.LastName}");
                item.SubItems.Add($"{ticket.Employee.FirstName} {ticket.Employee.LastName}");
                item.SubItems.Add($"{ticket.Timestamp.AddDays(ticket.Deadline).ToString("dd-MM-yyyy HH:mm")}");
                item.Tag = ticket;
                ticketListView.Items.Add(item);
            }
        }

        private void ticketListView_DoubleClick(object sender, EventArgs e)
        {
            if (ticketListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a ticket");
                return;
            }
            if (ticketListView.SelectedItems.Count > 1) 
            {
                MessageBox.Show("Please only select one ticket");
                return;
            }
            TicketEditUI.TicketEditUI ticketEdit = new TicketEditUI.TicketEditUI((Ticket)ticketListView.SelectedItems[0].Tag);
            ticketEdit.ShowDialog();
            if (!ticketEdit.canceled)
            {
                InitListView();
            }
        }
    }
}
