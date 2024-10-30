namespace UI.EmployeeUI
{
    partial class EmployeeUI
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
            employeeListView = new ListView();
            name = new ColumnHeader();
            email = new ColumnHeader();
            phoneNumber = new ColumnHeader();
            role = new ColumnHeader();
            department = new ColumnHeader();
            addEmployeeBtn = new Button();
            deleteEmployee = new Button();
            editEmployeeBtn = new Button();
            SuspendLayout();
            // 
            // employeeListView
            // 
            employeeListView.Columns.AddRange(new ColumnHeader[] { name, email, phoneNumber, role, department });
            employeeListView.Location = new Point(12, 12);
            employeeListView.Name = "employeeListView";
            employeeListView.Size = new Size(979, 529);
            employeeListView.TabIndex = 0;
            employeeListView.UseCompatibleStateImageBehavior = false;
            employeeListView.View = View.Details;
            // 
            // name
            // 
            name.Text = "Name";
            name.Width = 160;
            // 
            // email
            // 
            email.Text = "Email";
            email.Width = 260;
            // 
            // phoneNumber
            // 
            phoneNumber.Text = "Phone number";
            phoneNumber.Width = 160;
            // 
            // role
            // 
            role.Text = "Role";
            role.Width = 90;
            // 
            // department
            // 
            department.Text = "Department";
            department.Width = 160;
            // 
            // addEmployeeBtn
            // 
            addEmployeeBtn.Location = new Point(1036, 12);
            addEmployeeBtn.Name = "addEmployeeBtn";
            addEmployeeBtn.Size = new Size(134, 29);
            addEmployeeBtn.TabIndex = 1;
            addEmployeeBtn.Text = "Add Employee";
            addEmployeeBtn.UseVisualStyleBackColor = true;
            addEmployeeBtn.Click += addEmployeeBtn_Click;
            // 
            // deleteEmployee
            // 
            deleteEmployee.Location = new Point(1036, 82);
            deleteEmployee.Name = "deleteEmployee";
            deleteEmployee.Size = new Size(134, 29);
            deleteEmployee.TabIndex = 2;
            deleteEmployee.Text = "Delete Employee";
            deleteEmployee.UseVisualStyleBackColor = true;
            deleteEmployee.Click += deleteEmployee_Click;
            // 
            // editEmployeeBtn
            // 
            editEmployeeBtn.Location = new Point(1036, 47);
            editEmployeeBtn.Name = "editEmployeeBtn";
            editEmployeeBtn.Size = new Size(134, 29);
            editEmployeeBtn.TabIndex = 3;
            editEmployeeBtn.Text = "Edit Employee";
            editEmployeeBtn.UseVisualStyleBackColor = true;
            editEmployeeBtn.Click += editEmployeeBtn_Click;
            // 
            // EmployeeUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 553);
            Controls.Add(editEmployeeBtn);
            Controls.Add(deleteEmployee);
            Controls.Add(addEmployeeBtn);
            Controls.Add(employeeListView);
            Name = "EmployeeUI";
            Text = "EmployeeUI";
            ResumeLayout(false);
        }

        #endregion

        private ListView employeeListView;
        private ColumnHeader name;
        private ColumnHeader email;
        private ColumnHeader phoneNumber;
        private ColumnHeader role;
        private ColumnHeader department;
        private Button addEmployeeBtn;
        private Button deleteEmployee;
        private Button editEmployeeBtn;
    }
}