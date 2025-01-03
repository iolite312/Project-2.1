﻿using Logic;
using Model;
using Model.Enums;

namespace UI.TicketEditUI
{
    public partial class TicketEditUI : Form
    {
        public bool canceled = true;
        private bool isEditing = false;
        private Ticket _ticket;
        public TicketEditUI(Ticket ticket)
        {
            InitializeComponent();
            _ticket = ticket;
            InitTicket();
        }

        private void InitTicket()
        {
            FillComboBoxes();
            caseNameInput.Text = _ticket.CaseName;
            caseTypeCombo.SelectedItem = _ticket.Type;
            caseStatusCombo.SelectedItem = _ticket.Status;
            casePriorityCombo.SelectedItem = _ticket.Priority;
            caseHandlerCombo.SelectedItem = $"{_ticket.Handler.FirstName} {_ticket.Handler.LastName}";
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
            caseHandlerCombo.Items.Clear();

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
            
            foreach (Handler handler in GetHandlers())
            {
                caseHandlerCombo.Items.Add(handler.FirstName+" "+ handler.LastName);
                
            }
        }
        private List<Handler> GetHandlers()
        {
            TicketService _ticketService = new TicketService();
            return _ticketService.AllHandlers();
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
                canceled = false;
                FlipVisibilty();
                editTicketBtn.Text = "Confirm Edit";
                cancelBtn.Text = "Cancel Edit";
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to proceed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    TicketService _ticketService = new TicketService();
                    Ticket ticket = new Ticket(caseNameInput.Text, (ETicketType)caseTypeCombo.SelectedItem, (ETicketStatus)caseStatusCombo.SelectedItem, descriptionTextBox.Text, caseDatePickerDate.Value.Date.Add(caseDatePickerTime.Value.TimeOfDay), (ETicketPriority)casePriorityCombo.SelectedItem, GetHandler(caseHandlerCombo.SelectedItem.ToString()), _ticket.Employee, _ticket.Deadline, _ticket.Id);
                    _ticketService.UpdateTicket(ticket);
                    Close();
                }
            }
        }
        private Handler GetHandler(string name)
        {
            List<Handler> handlers = GetHandlers();
            foreach (Handler handler in handlers)
            {
                if (handler.FirstName + " " + handler.LastName == name)
                {
                    return handler;
                }
            }
            throw new Exception($"Handler with name {name} not found.");
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
            caseHandlerCombo.Visible = !caseHandlerCombo.Visible;
        }
    }
}
