using Logic;
using Model;
using Model.Enums;

namespace UI.TicketEditUI
{
    public partial class TicketEditUI : Form
    {
        public bool canceled = false;
        private bool isEditing = false;
        private Ticket _ticket;
        public Ticket Ticket { get { return _ticket; } }
        private TicketService _ticketService;
        public TicketEditUI(Ticket ticket)
        {
            InitializeComponent();
            _ticket = ticket;
            _ticketService = new TicketService();
            InitTicket();
        }

        private void InitTicket()
        {
            FillComboBoxes();
            caseNameInput.Text = _ticket.CaseName;
            caseTypeCombo.SelectedItem = _ticket.Type;
            caseStatusCombo.SelectedItem = _ticket.Status;
            casePriorityCombo.SelectedItem = _ticket.Priority;
            caseRequesterInputLbl.Text = $"{_ticket.Employee.FirstName} {_ticket.Employee.LastName}";
            caseHandlerInputLbl.Text = $"{_ticket.Handler.FirstName} {_ticket.Handler.LastName}";
            caseDatePickerDate.Value = _ticket.Timestamp;
            descriptionTextBox.Text = _ticket.Description;
            caseDateOverlay.Text = _ticket.Timestamp.ToString("dd-MM-yyyy HH:mm");
            caseDescriptionOverlay.Text = _ticket.Description;
            casePriorityOverlay.Text = _ticket.Priority.ToString();
            caseNameOverlay.Text = _ticket.CaseName;
            caseStatusOverlay.Text = _ticket.Status.ToString();
            caseTypeOverlay.Text = _ticket.Type.ToString();
        }

        private void FillComboBoxes()
        {
            casePriorityCombo.Items.Clear();
            caseStatusCombo.Items.Clear();
            caseTypeCombo.Items.Clear();

            foreach (ETicketPriority eTicketPriority in Enum.GetValues(typeof(ETicketPriority)))
            {
                casePriorityCombo.Items.Add(eTicketPriority);
            }

            foreach (ETicketStatus eTicketStatus in Enum.GetValues(typeof(ETicketStatus)))
            {
                caseStatusCombo.Items.Add(eTicketStatus);
            }

            foreach (ETicketType eTicketType in Enum.GetValues(typeof(ETicketType)))
            {
                caseTypeCombo.Items.Add(eTicketType);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                statusLbl.Text = "Viewing Ticket";
                FlipVisibilty();
                isEditing = false;
                editTicketBtn.Text = "Edit Ticket";
                cancelBtn.Text = "Go back";
            }
            else
            {
                canceled = true;
                Close();
            }

        }

        private void editTicketBtn_Click(object sender, EventArgs e)
        {
            if (!isEditing)
            {
                isEditing = true;
                statusLbl.Text = "Editing Ticket";
                FlipVisibilty();
                editTicketBtn.Text = "Confirm Edit";
                cancelBtn.Text = "Cancel Edit";
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to proceed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Ticket ticket = new Ticket(caseNameInput.Text, (ETicketType)caseTypeCombo.SelectedItem, (ETicketStatus)caseStatusCombo.SelectedItem, descriptionTextBox.Text, caseDatePickerDate.Value.Date.Add(caseDatePickerTime.Value.TimeOfDay), (ETicketPriority)casePriorityCombo.SelectedItem, _ticket.Handler, _ticket.Employee, _ticket.Deadline, _ticket.Id);
                    _ticketService.UpdateTicket(ticket);
                    Close();
                }
            }

        }

        private void FlipVisibilty()
        {
            caseDescriptionOverlay.Visible = !caseDescriptionOverlay.Visible;
            caseNameOverlay.Visible = !caseNameOverlay.Visible;
            caseStatusOverlay.Visible = !caseStatusOverlay.Visible;
            caseTypeOverlay.Visible = !caseTypeOverlay.Visible;
            casePriorityOverlay.Visible = !casePriorityOverlay.Visible;
            caseDateOverlay.Visible = !caseDateOverlay.Visible;
            descriptionTextBox.Visible = !descriptionTextBox.Visible;
            casePriorityCombo.Visible = !casePriorityCombo.Visible;
            caseStatusCombo.Visible = !caseStatusCombo.Visible;
            caseTypeCombo.Visible = !caseTypeCombo.Visible;
            caseNameInput.Visible = !caseNameInput.Visible;
            caseDatePickerDate.Visible = !caseDatePickerDate.Visible;
            caseDatePickerTime.Visible = !caseDatePickerTime.Visible;
        }
    }
}
