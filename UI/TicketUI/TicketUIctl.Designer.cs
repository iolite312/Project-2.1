namespace UI.TicketUI
{
    partial class TicketUIctl
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

        #region Component Designer generated code

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
            txtSearch = new TextBox();
            chkbAndSearch = new CheckBox();
            btnSearch = new Button();
            SuspendLayout();
            // 
            // ticketListView
            // 
            ticketListView.Columns.AddRange(new ColumnHeader[] { caseName, type, status, timestamp, priority, handler, employee, deadline });
            ticketListView.Location = new Point(0, 0);
            ticketListView.Name = "ticketListView";
            ticketListView.Size = new Size(1084, 492);
            ticketListView.TabIndex = 1;
            ticketListView.UseCompatibleStateImageBehavior = false;
            ticketListView.View = View.Details;
            ticketListView.MouseDoubleClick += ticketListView_MouseDoubleClick;
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
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 498);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(508, 27);
            txtSearch.TabIndex = 1;
            // 
            // chkbAndSearch
            // 
            chkbAndSearch.AutoSize = true;
            chkbAndSearch.Location = new Point(526, 498);
            chkbAndSearch.Name = "chkbAndSearch";
            chkbAndSearch.Size = new Size(205, 19);
            chkbAndSearch.TabIndex = 2;
            chkbAndSearch.Text = "Search case name and description";
            chkbAndSearch.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(919, 498);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(105, 23);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // TicketUIctl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ticketListView);
            Controls.Add(txtSearch);
            Controls.Add(chkbAndSearch);
            Controls.Add(btnSearch);
            Margin = new Padding(2);
            Name = "TicketUIctl";
            Size = new Size(1106, 553);
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
        private TextBox txtSearch;
        private CheckBox chkbAndSearch;
        private Button btnSearch;
    }
}
