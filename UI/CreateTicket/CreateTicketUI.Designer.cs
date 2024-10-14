namespace UI.CreateTicket
{
    partial class CreateTicketUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblDate = new Label();
            lblSubject = new Label();
            lblType = new Label();
            lblRepByUser = new Label();
            lblPriority = new Label();
            lblDeadline = new Label();
            lblDescription = new Label();
            dateTimePicker = new DateTimePicker();
            txtSubject = new TextBox();
            cbIncident = new ComboBox();
            cbPriority = new ComboBox();
            txtDescription = new TextBox();
            txtUser = new TextBox();
            btnSubmit = new Button();
            dateTimePickerDeadline = new DateTimePicker();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(144, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(756, 78);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Create new incident ticket";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(144, 141);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(230, 32);
            lblDate.TabIndex = 1;
            lblDate.Text = "Date/Time reported:";
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Location = new Point(144, 214);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(220, 32);
            lblSubject.TabIndex = 2;
            lblSubject.Text = "Subject of incident:";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(144, 292);
            lblType.Name = "lblType";
            lblType.Size = new Size(192, 32);
            lblType.TabIndex = 3;
            lblType.Text = "Type of incident:";
            // 
            // lblRepByUser
            // 
            lblRepByUser.AutoSize = true;
            lblRepByUser.Location = new Point(144, 363);
            lblRepByUser.Name = "lblRepByUser";
            lblRepByUser.Size = new Size(201, 32);
            lblRepByUser.TabIndex = 4;
            lblRepByUser.Text = "Reported by user:";
            // 
            // lblPriority
            // 
            lblPriority.AutoSize = true;
            lblPriority.Location = new Point(144, 442);
            lblPriority.Name = "lblPriority";
            lblPriority.Size = new Size(94, 32);
            lblPriority.TabIndex = 5;
            lblPriority.Text = "Priority:";
            // 
            // lblDeadline
            // 
            lblDeadline.AutoSize = true;
            lblDeadline.Location = new Point(144, 518);
            lblDeadline.Name = "lblDeadline";
            lblDeadline.Size = new Size(223, 32);
            lblDeadline.TabIndex = 6;
            lblDeadline.Text = "Deadline/follow up:";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(144, 596);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(140, 32);
            lblDescription.TabIndex = 7;
            lblDescription.Text = "Description:";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Enabled = false;
            dateTimePicker.Location = new Point(500, 141);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(400, 39);
            dateTimePicker.TabIndex = 8;
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(500, 214);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(400, 39);
            txtSubject.TabIndex = 9;
            // 
            // cbIncident
            // 
            cbIncident.FormattingEnabled = true;
            cbIncident.Location = new Point(500, 292);
            cbIncident.Name = "cbIncident";
            cbIncident.Size = new Size(400, 40);
            cbIncident.TabIndex = 10;
            // 
            // cbPriority
            // 
            cbPriority.FormattingEnabled = true;
            cbPriority.Location = new Point(500, 442);
            cbPriority.Name = "cbPriority";
            cbPriority.Size = new Size(400, 40);
            cbPriority.TabIndex = 11;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(500, 596);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(400, 166);
            txtDescription.TabIndex = 12;
            // 
            // txtUser
            // 
            txtUser.Enabled = false;
            txtUser.Location = new Point(500, 363);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(400, 39);
            txtUser.TabIndex = 13;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(500, 805);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(400, 46);
            btnSubmit.TabIndex = 15;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // dateTimePickerDeadline
            // 
            dateTimePickerDeadline.Location = new Point(500, 518);
            dateTimePickerDeadline.Name = "dateTimePickerDeadline";
            dateTimePickerDeadline.Size = new Size(400, 39);
            dateTimePickerDeadline.TabIndex = 14;
            // 
            // CreateTicketUI
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 885);
            Controls.Add(btnSubmit);
            Controls.Add(dateTimePickerDeadline);
            Controls.Add(txtUser);
            Controls.Add(txtDescription);
            Controls.Add(cbPriority);
            Controls.Add(cbIncident);
            Controls.Add(txtSubject);
            Controls.Add(dateTimePicker);
            Controls.Add(lblDescription);
            Controls.Add(lblDeadline);
            Controls.Add(lblPriority);
            Controls.Add(lblRepByUser);
            Controls.Add(lblType);
            Controls.Add(lblSubject);
            Controls.Add(lblDate);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "CreateTicketUI";
            Text = "Create Ticket";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblDate;
        private Label lblSubject;
        private Label lblType;
        private Label lblRepByUser;
        private Label lblPriority;
        private Label lblDeadline;
        private Label lblDescription;
        private DateTimePicker dateTimePicker;
        private TextBox txtSubject;
        private ComboBox cbIncident;
        private ComboBox cbPriority;
        private TextBox txtDescription;
        private TextBox txtUser;
        private Button btnSubmit;
        private DateTimePicker dateTimePickerDeadline;
    }
}