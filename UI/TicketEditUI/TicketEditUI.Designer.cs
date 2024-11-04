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
            caseHandlerCombo = new ComboBox();
            SuspendLayout();
            // 
            // caseNameInput
            // 
            caseNameInput.Location = new Point(97, 44);
            caseNameInput.Margin = new Padding(3, 2, 3, 2);
            caseNameInput.Name = "caseNameInput";
            caseNameInput.Size = new Size(177, 23);
            caseNameInput.TabIndex = 0;
            caseNameInput.Visible = false;
            // 
            // statusLbl
            // 
            statusLbl.AutoSize = true;
            statusLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            statusLbl.Location = new Point(10, 7);
            statusLbl.Name = "statusLbl";
            statusLbl.Size = new Size(107, 21);
            statusLbl.TabIndex = 1;
            statusLbl.Text = "Viewing ticket";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 46);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 2;
            label2.Text = "Case Name:";
            // 
            // caseTypeCombo
            // 
            caseTypeCombo.FormattingEnabled = true;
            caseTypeCombo.Location = new Point(400, 43);
            caseTypeCombo.Margin = new Padding(3, 2, 3, 2);
            caseTypeCombo.Name = "caseTypeCombo";
            caseTypeCombo.Size = new Size(133, 23);
            caseTypeCombo.TabIndex = 3;
            caseTypeCombo.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(326, 46);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 4;
            label3.Text = "Case Type:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(318, 87);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 6;
            label4.Text = "Case Status:";
            // 
            // caseStatusCombo
            // 
            caseStatusCombo.FormattingEnabled = true;
            caseStatusCombo.Location = new Point(400, 85);
            caseStatusCombo.Margin = new Padding(3, 2, 3, 2);
            caseStatusCombo.Name = "caseStatusCombo";
            caseStatusCombo.Size = new Size(133, 23);
            caseStatusCombo.TabIndex = 5;
            caseStatusCombo.Visible = false;
            // 
            // caseDatePickerDate
            // 
            caseDatePickerDate.Format = DateTimePickerFormat.Short;
            caseDatePickerDate.Location = new Point(94, 86);
            caseDatePickerDate.Margin = new Padding(3, 2, 3, 2);
            caseDatePickerDate.Name = "caseDatePickerDate";
            caseDatePickerDate.Size = new Size(107, 23);
            caseDatePickerDate.TabIndex = 7;
            caseDatePickerDate.Value = new DateTime(2024, 10, 12, 18, 57, 5, 0);
            caseDatePickerDate.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 87);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 8;
            label5.Text = "Case Date:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(562, 46);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 10;
            label6.Text = "Case Priority:";
            // 
            // casePriorityCombo
            // 
            casePriorityCombo.FormattingEnabled = true;
            casePriorityCombo.Location = new Point(649, 43);
            casePriorityCombo.Margin = new Padding(3, 2, 3, 2);
            casePriorityCombo.Name = "casePriorityCombo";
            casePriorityCombo.Size = new Size(133, 23);
            casePriorityCombo.TabIndex = 9;
            casePriorityCombo.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(556, 89);
            label7.Name = "label7";
            label7.Size = new Size(80, 15);
            label7.TabIndex = 11;
            label7.Text = "Case Handler:";
            // 
            // caseHandlerInputLbl
            // 
            caseHandlerInputLbl.AutoSize = true;
            caseHandlerInputLbl.Location = new Point(649, 89);
            caseHandlerInputLbl.Name = "caseHandlerInputLbl";
            caseHandlerInputLbl.Size = new Size(0, 15);
            caseHandlerInputLbl.TabIndex = 12;
            // 
            // caseRequesterInputLbl
            // 
            caseRequesterInputLbl.AutoSize = true;
            caseRequesterInputLbl.Location = new Point(896, 46);
            caseRequesterInputLbl.Name = "caseRequesterInputLbl";
            caseRequesterInputLbl.Size = new Size(0, 15);
            caseRequesterInputLbl.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(792, 46);
            label9.Name = "label9";
            label9.Size = new Size(90, 15);
            label9.TabIndex = 13;
            label9.Text = "Case Requester:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 123);
            label8.Name = "label8";
            label8.Size = new Size(67, 15);
            label8.TabIndex = 15;
            label8.Text = "Description";
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(16, 147);
            descriptionTextBox.Margin = new Padding(3, 2, 3, 2);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(517, 246);
            descriptionTextBox.TabIndex = 16;
            descriptionTextBox.Text = "";
            descriptionTextBox.Visible = false;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(942, 384);
            cancelBtn.Margin = new Padding(3, 2, 3, 2);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(82, 22);
            cancelBtn.TabIndex = 17;
            cancelBtn.Text = "Go Back";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // editTicketBtn
            // 
            editTicketBtn.Location = new Point(854, 384);
            editTicketBtn.Margin = new Padding(3, 2, 3, 2);
            editTicketBtn.Name = "editTicketBtn";
            editTicketBtn.Size = new Size(82, 22);
            editTicketBtn.TabIndex = 18;
            editTicketBtn.Text = "Edit Ticket";
            editTicketBtn.UseVisualStyleBackColor = true;
            editTicketBtn.Click += editTicketBtn_Click;
            // 
            // caseNameOverlay
            // 
            caseNameOverlay.AutoSize = true;
            caseNameOverlay.Location = new Point(97, 46);
            caseNameOverlay.Name = "caseNameOverlay";
            caseNameOverlay.Size = new Size(0, 15);
            caseNameOverlay.TabIndex = 19;
            // 
            // caseDatePickerTime
            // 
            caseDatePickerTime.Format = DateTimePickerFormat.Time;
            caseDatePickerTime.Location = new Point(206, 86);
            caseDatePickerTime.Margin = new Padding(3, 2, 3, 2);
            caseDatePickerTime.Name = "caseDatePickerTime";
            caseDatePickerTime.ShowUpDown = true;
            caseDatePickerTime.Size = new Size(78, 23);
            caseDatePickerTime.TabIndex = 20;
            caseDatePickerTime.Visible = false;
            // 
            // caseTypeOverlay
            // 
            caseTypeOverlay.AutoSize = true;
            caseTypeOverlay.Location = new Point(400, 46);
            caseTypeOverlay.Name = "caseTypeOverlay";
            caseTypeOverlay.Size = new Size(0, 15);
            caseTypeOverlay.TabIndex = 21;
            // 
            // caseStatusOverlay
            // 
            caseStatusOverlay.AutoSize = true;
            caseStatusOverlay.Location = new Point(400, 89);
            caseStatusOverlay.Name = "caseStatusOverlay";
            caseStatusOverlay.Size = new Size(0, 15);
            caseStatusOverlay.TabIndex = 22;
            // 
            // casePriorityOverlay
            // 
            casePriorityOverlay.AutoSize = true;
            casePriorityOverlay.Location = new Point(649, 45);
            casePriorityOverlay.Name = "casePriorityOverlay";
            casePriorityOverlay.Size = new Size(0, 15);
            casePriorityOverlay.TabIndex = 23;
            // 
            // caseDescriptionOverlay
            // 
            caseDescriptionOverlay.AutoSize = true;
            caseDescriptionOverlay.Location = new Point(16, 147);
            caseDescriptionOverlay.MaximumSize = new Size(350, 450);
            caseDescriptionOverlay.Name = "caseDescriptionOverlay";
            caseDescriptionOverlay.Size = new Size(0, 15);
            caseDescriptionOverlay.TabIndex = 24;
            // 
            // caseDateOverlay
            // 
            caseDateOverlay.AutoSize = true;
            caseDateOverlay.Location = new Point(97, 87);
            caseDateOverlay.Name = "caseDateOverlay";
            caseDateOverlay.Size = new Size(0, 15);
            caseDateOverlay.TabIndex = 25;
            // 
            // caseHandlerCombo
            // 
            caseHandlerCombo.FormattingEnabled = true;
            caseHandlerCombo.Location = new Point(649, 86);
            caseHandlerCombo.Margin = new Padding(3, 2, 3, 2);
            caseHandlerCombo.Name = "caseHandlerCombo";
            caseHandlerCombo.Size = new Size(133, 23);
            caseHandlerCombo.TabIndex = 26;
            caseHandlerCombo.Visible = false;
            // 
            // TicketEditUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 415);
            Controls.Add(caseHandlerCombo);
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
            Margin = new Padding(3, 2, 3, 2);
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
        private ComboBox caseHandlerCombo;
    }
}