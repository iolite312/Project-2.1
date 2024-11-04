using DAL;
using Logic;
using Model;
using Model.Enums;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace UI.TicketUI
{
    public partial class TicketUI : Form
    {
        private Employee _employee;
        private List<Ticket> _tickets = new List<Ticket>();

        public TicketUI()
        {
            InitializeComponent();
            InitListView();
        }
        public TicketUI(List<Ticket> tickets, Employee employee)
        {
            _tickets = tickets;
            InitializeComponent();
            InitListView();
            _employee = employee;
        }
        private void InitListView()
        {
            ticketListView.Items.Clear();

            foreach (Ticket ticket in _tickets)
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
                updateAfterChange();
            }
        }
        private void updateAfterChange()
        {
            TicketService ticketService = new TicketService();
            if (_employee != null && _employee.Role == ERole.Employee)
            {
                _tickets = ticketService.GetEmployeeTickets(_employee.Id);
            }
            else
            {
                _tickets = ticketService.GetTickets();
            }
            InitListView();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            TicketService ticketService = new TicketService();
            List<string> keywords = txtSearch.Text.Split(' ').ToList();
            if (chkbAndSearch.Checked) 
            { 
                _tickets = ticketService.GetTicketsByMatchAnd(keywords);
            }
            else
            {
                _tickets = ticketService.GetTicketsByMatchOr(keywords);
            }

            InitListView();
        }
    }
}
