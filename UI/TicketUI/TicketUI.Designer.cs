﻿namespace UI.TicketUI
{
    partial class TicketUI
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
            ticketListView = new ListView();
            caseName = new ColumnHeader();
            type = new ColumnHeader();
            status = new ColumnHeader();
            timestamp = new ColumnHeader();
            priority = new ColumnHeader();
            handler = new ColumnHeader();
            employee = new ColumnHeader();
            deadline = new ColumnHeader();
            SuspendLayout();
            // 
            // ticketListView
            // 
            ticketListView.Columns.AddRange(new ColumnHeader[] { caseName, type, status, timestamp, priority, handler, employee, deadline });
            ticketListView.Location = new Point(12, 24);
            ticketListView.Name = "ticketListView";
            ticketListView.Size = new Size(1158, 492);
            ticketListView.TabIndex = 0;
            ticketListView.UseCompatibleStateImageBehavior = false;
            ticketListView.View = View.Details;
            ticketListView.DoubleClick += ticketListView_DoubleClick;
            // 
            // caseName
            // 
            caseName.Text = "caseName";
            caseName.Width = 130;
            // 
            // type
            // 
            type.Text = "Type";
            type.Width = 90;
            // 
            // status
            // 
            status.Text = "Status";
            status.Width = 90;
            // 
            // timestamp
            // 
            timestamp.Text = "Time";
            timestamp.Width = 160;
            // 
            // priority
            // 
            priority.Text = "Priority";
            priority.Width = 90;
            // 
            // handler
            // 
            handler.Text = "Handler";
            handler.Width = 160;
            // 
            // employee
            // 
            employee.Text = "Employee";
            employee.Width = 160;
            // 
            // deadline
            // 
            deadline.Text = "Deadline";
            deadline.Width = 160;
            // 
            // TicketUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 553);
            Controls.Add(ticketListView);
            Name = "TicketUI";
            Text = "TicketUI";
            ResumeLayout(false);
        }

        #endregion

        private ListView ticketListView;
        private ColumnHeader caseName;
        private ColumnHeader type;
        private ColumnHeader status;
        private ColumnHeader timestamp;
        private ColumnHeader priority;
        private ColumnHeader handler;
        private ColumnHeader employee;
        private ColumnHeader deadline;
    }
}