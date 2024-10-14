
using Model;
using Model.Enums;

namespace UI.CreateTicket
{
    public partial class CreateTicketUI : Form
    {
        Employee loggedEmployee = new Employee("John", "Doe", "jhondoe@gmail.com", "0612345678", ERole.Employee, null, null, EDepartment.ITSupport, null);
        public CreateTicketUI()
        {
            InitializeComponent();
            StartConfig();
        }

        public Ticket CreateTicket()
        {
            Ticket ticket = new Ticket();
            ticket.Timestamp = dateTimePicker.Value;
            ticket.CaseName = txtSubject.Text;
            ticket.Type = (ETicketType)cbIncident.SelectedIndex;
            ticket.Employee = loggedEmployee;
            ticket.Priority = (ETicketPriority)cbIncident.SelectedIndex;
            ticket.Deadline = dateTimePickerDeadline.Value.Day - ticket.Timestamp.Day;
            ticket.Description = txtDescription.Text;

            return ticket;
        }

        private void StartConfig()
        {
            txtUser.Text = $"{loggedEmployee.FirstName} {loggedEmployee.LastName}";
            cbIncident.DataSource = Enum.GetValues(typeof(ETicketType));
            cbPriority.DataSource = Enum.GetValues(typeof(ETicketPriority));
            cbPriority.SelectedIndex = cbPriority.Items.Count - 1;
            txtUser.Text = $"{loggedEmployee.FirstName} {loggedEmployee.LastName}";
            dateTimePicker.MinDate = DateTime.Now;
            dateTimePickerDeadline.MinDate = DateTime.Now.AddDays(1);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (CheckTextField(txtSubject.Text) && CheckTextField(txtDescription.Text))
                CreateTicket();
        }

        private bool CheckTextField(string textField) 
        {
            if (textField == "" || textField == null)
                throw new Exception("No text in field(s)!");
            
            return true;
        } 
    }
}
