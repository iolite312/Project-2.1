namespace UI.TicketEditUI
{
    partial class TicketEditUI
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
            caseNameInput = new TextBox();
            statusLbl = new Label();
            label2 = new Label();
            caseTypeCombo = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            caseStatusCombo = new ComboBox();
            caseDatePickerDate = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            casePriorityCombo = new ComboBox();
            label7 = new Label();
            caseHandlerInputLbl = new Label();
            caseRequesterInputLbl = new Label();
            label9 = new Label();
            label8 = new Label();
            descriptionTextBox = new RichTextBox();
            cancelBtn = new Button();
            editTicketBtn = new Button();
            caseNameOverlay = new Label();
            caseDatePickerTime = new DateTimePicker();
            caseTypeOverlay = new Label();
            caseStatusOverlay = new Label();
            casePriorityOverlay = new Label();
            caseDescriptionOverlay = new Label();
            caseDateOverlay = new Label();
            SuspendLayout();
            // 
            // caseNameInput
            // 
            caseNameInput.Location = new Point(111, 58);
            caseNameInput.Name = "caseNameInput";
            caseNameInput.Size = new Size(202, 27);
            caseNameInput.TabIndex = 0;
            caseNameInput.Visible = false;
            // 
            // statusLbl
            // 
            statusLbl.AutoSize = true;
            statusLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            statusLbl.Location = new Point(12, 9);
            statusLbl.Name = "statusLbl";
            statusLbl.Size = new Size(134, 28);
            statusLbl.TabIndex = 1;
            statusLbl.Text = "Viewing ticket";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 61);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 2;
            label2.Text = "Case Name:";
            // 
            // caseTypeCombo
            // 
            caseTypeCombo.FormattingEnabled = true;
            caseTypeCombo.Location = new Point(457, 57);
            caseTypeCombo.Name = "caseTypeCombo";
            caseTypeCombo.Size = new Size(151, 28);
            caseTypeCombo.TabIndex = 3;
            caseTypeCombo.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(373, 61);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 4;
            label3.Text = "Case Type:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(364, 116);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 6;
            label4.Text = "Case Status:";
            // 
            // caseStatusCombo
            // 
            caseStatusCombo.FormattingEnabled = true;
            caseStatusCombo.Location = new Point(457, 113);
            caseStatusCombo.Name = "caseStatusCombo";
            caseStatusCombo.Size = new Size(151, 28);
            caseStatusCombo.TabIndex = 5;
            caseStatusCombo.Visible = false;
            // 
            // caseDatePickerDate
            // 
            caseDatePickerDate.Format = DateTimePickerFormat.Short;
            caseDatePickerDate.Location = new Point(108, 114);
            caseDatePickerDate.Name = "caseDatePickerDate";
            caseDatePickerDate.Size = new Size(122, 27);
            caseDatePickerDate.TabIndex = 7;
            caseDatePickerDate.Value = new DateTime(2024, 10, 12, 18, 57, 5, 0);
            caseDatePickerDate.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 116);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 8;
            label5.Text = "Case Date:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(642, 61);
            label6.Name = "label6";
            label6.Size = new Size(94, 20);
            label6.TabIndex = 10;
            label6.Text = "Case Priority:";
            // 
            // casePriorityCombo
            // 
            casePriorityCombo.FormattingEnabled = true;
            casePriorityCombo.Location = new Point(742, 57);
            casePriorityCombo.Name = "casePriorityCombo";
            casePriorityCombo.Size = new Size(151, 28);
            casePriorityCombo.TabIndex = 9;
            casePriorityCombo.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(636, 119);
            label7.Name = "label7";
            label7.Size = new Size(100, 20);
            label7.TabIndex = 11;
            label7.Text = "Case Handler:";
            // 
            // caseHandlerInputLbl
            // 
            caseHandlerInputLbl.AutoSize = true;
            caseHandlerInputLbl.Location = new Point(742, 119);
            caseHandlerInputLbl.Name = "caseHandlerInputLbl";
            caseHandlerInputLbl.Size = new Size(0, 20);
            caseHandlerInputLbl.TabIndex = 12;
            // 
            // caseRequesterInputLbl
            // 
            caseRequesterInputLbl.AutoSize = true;
            caseRequesterInputLbl.Location = new Point(1024, 61);
            caseRequesterInputLbl.Name = "caseRequesterInputLbl";
            caseRequesterInputLbl.Size = new Size(0, 20);
            caseRequesterInputLbl.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(905, 61);
            label9.Name = "label9";
            label9.Size = new Size(113, 20);
            label9.TabIndex = 13;
            label9.Text = "Case Requester:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 164);
            label8.Name = "label8";
            label8.Size = new Size(85, 20);
            label8.TabIndex = 15;
            label8.Text = "Description";
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(18, 196);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(590, 327);
            descriptionTextBox.TabIndex = 16;
            descriptionTextBox.Text = "";
            descriptionTextBox.Visible = false;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(1076, 512);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(94, 29);
            cancelBtn.TabIndex = 17;
            cancelBtn.Text = "Go Back";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // editTicketBtn
            // 
            editTicketBtn.Location = new Point(976, 512);
            editTicketBtn.Name = "editTicketBtn";
            editTicketBtn.Size = new Size(94, 29);
            editTicketBtn.TabIndex = 18;
            editTicketBtn.Text = "Edit Ticket";
            editTicketBtn.UseVisualStyleBackColor = true;
            editTicketBtn.Click += editTicketBtn_Click;
            // 
            // caseNameOverlay
            // 
            caseNameOverlay.AutoSize = true;
            caseNameOverlay.Location = new Point(111, 61);
            caseNameOverlay.Name = "caseNameOverlay";
            caseNameOverlay.Size = new Size(0, 20);
            caseNameOverlay.TabIndex = 19;
            // 
            // caseDatePickerTime
            // 
            caseDatePickerTime.Format = DateTimePickerFormat.Time;
            caseDatePickerTime.Location = new Point(236, 114);
            caseDatePickerTime.Name = "caseDatePickerTime";
            caseDatePickerTime.ShowUpDown = true;
            caseDatePickerTime.Size = new Size(89, 27);
            caseDatePickerTime.TabIndex = 20;
            caseDatePickerTime.Visible = false;
            // 
            // caseTypeOverlay
            // 
            caseTypeOverlay.AutoSize = true;
            caseTypeOverlay.Location = new Point(457, 61);
            caseTypeOverlay.Name = "caseTypeOverlay";
            caseTypeOverlay.Size = new Size(0, 20);
            caseTypeOverlay.TabIndex = 21;
            // 
            // caseStatusOverlay
            // 
            caseStatusOverlay.AutoSize = true;
            caseStatusOverlay.Location = new Point(457, 119);
            caseStatusOverlay.Name = "caseStatusOverlay";
            caseStatusOverlay.Size = new Size(0, 20);
            caseStatusOverlay.TabIndex = 22;
            // 
            // casePriorityOverlay
            // 
            casePriorityOverlay.AutoSize = true;
            casePriorityOverlay.Location = new Point(742, 60);
            casePriorityOverlay.Name = "casePriorityOverlay";
            casePriorityOverlay.Size = new Size(0, 20);
            casePriorityOverlay.TabIndex = 23;
            // 
            // caseDescriptionOverlay
            // 
            caseDescriptionOverlay.AutoSize = true;
            caseDescriptionOverlay.Location = new Point(18, 196);
            caseDescriptionOverlay.MaximumSize = new Size(400, 600);
            caseDescriptionOverlay.Name = "caseDescriptionOverlay";
            caseDescriptionOverlay.Size = new Size(0, 20);
            caseDescriptionOverlay.TabIndex = 24;
            // 
            // caseDateOverlay
            // 
            caseDateOverlay.AutoSize = true;
            caseDateOverlay.Location = new Point(111, 116);
            caseDateOverlay.Name = "caseDateOverlay";
            caseDateOverlay.Size = new Size(0, 20);
            caseDateOverlay.TabIndex = 25;
            // 
            // TicketEditUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 553);
            Controls.Add(caseDateOverlay);
            Controls.Add(caseDescriptionOverlay);
            Controls.Add(casePriorityOverlay);
            Controls.Add(caseStatusOverlay);
            Controls.Add(caseTypeOverlay);
            Controls.Add(caseDatePickerTime);
            Controls.Add(caseNameOverlay);
            Controls.Add(editTicketBtn);
            Controls.Add(cancelBtn);
            Controls.Add(descriptionTextBox);
            Controls.Add(label8);
            Controls.Add(caseRequesterInputLbl);
            Controls.Add(label9);
            Controls.Add(caseHandlerInputLbl);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(casePriorityCombo);
            Controls.Add(label5);
            Controls.Add(caseDatePickerDate);
            Controls.Add(label4);
            Controls.Add(caseStatusCombo);
            Controls.Add(label3);
            Controls.Add(caseTypeCombo);
            Controls.Add(label2);
            Controls.Add(statusLbl);
            Controls.Add(caseNameInput);
            Name = "TicketEditUI";
            Text = "TicketEditUI";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox caseNameInput;
        private Label statusLbl;
        private Label label2;
        private ComboBox caseTypeCombo;
        private Label label3;
        private Label label4;
        private ComboBox caseStatusCombo;
        private DateTimePicker caseDatePickerDate;
        private Label label5;
        private Label label6;
        private ComboBox casePriorityCombo;
        private Label label7;
        private Label caseHandlerInputLbl;
        private Label caseRequesterInputLbl;
        private Label label9;
        private Label label8;
        private RichTextBox descriptionTextBox;
        private Button cancelBtn;
        private Button editTicketBtn;
        private Label caseNameOverlay;
        private DateTimePicker caseDatePickerTime;
        private Label caseTypeOverlay;
        private Label caseStatusOverlay;
        private Label casePriorityOverlay;
        private Label caseDescriptionOverlay;
        private Label caseDateOverlay;
    }
}