
using Model;
using Model.Enums;
using Logic;

namespace UI.CreateTicket
{
    public partial class CreateTicketUI : Form
    {
        private Employee loggedEmployee;
        private TicketService ticketService;
        
        public CreateTicketUI(Employee employee)
        {
            this.loggedEmployee = employee;
            this.ticketService = new TicketService();
            InitializeComponent();
            StartConfig();
        }

        public Ticket CreateTicket()
        {
            int deadLineInDays = dateTimePickerDeadline.Value.Day - dateTimePicker.Value.Day;
            return new Ticket(
                txtSubject.Text, (ETicketType)cbIncident.SelectedIndex,
                ETicketStatus.Open, txtDescription.Text,
                dateTimePicker.Value, (ETicketPriority)cbPriority.SelectedIndex,
                loggedEmployee, loggedEmployee, 
                deadLineInDays, null
                );
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
            try
            {
                if (CheckTextField(txtSubject.Text) && CheckTextField(txtDescription.Text))
                    ticketService.CreateTicket(CreateTicket());

            }
            catch (Exception exception) { MessageBox.Show(exception.Message); }


        }

        private bool CheckTextField(string textField) 
        {
            if (textField == "" || textField == null) 
                throw new Exception("No text in field(s)!");

            return true;
        } 
    }
}
