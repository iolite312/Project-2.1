namespace UI.EmployeeUI
{
    partial class EmployeeUIctl
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
            employeeListView = new ListView();
            name = new ColumnHeader();
            email = new ColumnHeader();
            phoneNumber = new ColumnHeader();
            role = new ColumnHeader();
            department = new ColumnHeader();
            editEmployeeBtn = new Button();
            deleteEmployee = new Button();
            addEmployeeBtn = new Button();
            SuspendLayout();
            // 
            // employeeListView
            // 
            employeeListView.Columns.AddRange(new ColumnHeader[] { name, email, phoneNumber, role, department });
            employeeListView.Location = new Point(21, 36);
            employeeListView.Name = "employeeListView";
            employeeListView.Size = new Size(979, 529);
            employeeListView.TabIndex = 4;
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
            // editEmployeeBtn
            // 
            editEmployeeBtn.Location = new Point(1045, 71);
            editEmployeeBtn.Name = "editEmployeeBtn";
            editEmployeeBtn.Size = new Size(134, 29);
            editEmployeeBtn.TabIndex = 7;
            editEmployeeBtn.Text = "Edit Employee";
            editEmployeeBtn.UseVisualStyleBackColor = true;
            editEmployeeBtn.Click += editEmployeeBtn_Click;
            // 
            // deleteEmployee
            // 
            deleteEmployee.Location = new Point(1045, 106);
            deleteEmployee.Name = "deleteEmployee";
            deleteEmployee.Size = new Size(134, 29);
            deleteEmployee.TabIndex = 6;
            deleteEmployee.Text = "Delete Employee";
            deleteEmployee.UseVisualStyleBackColor = true;
            deleteEmployee.Click += deleteEmployee_Click;
            // 
            // addEmployeeBtn
            // 
            addEmployeeBtn.Location = new Point(1045, 36);
            addEmployeeBtn.Name = "addEmployeeBtn";
            addEmployeeBtn.Size = new Size(134, 29);
            addEmployeeBtn.TabIndex = 5;
            addEmployeeBtn.Text = "Add Employee";
            addEmployeeBtn.UseVisualStyleBackColor = true;
            addEmployeeBtn.Click += addEmployeeBtn_Click;
            // 
            // EmployeeUIctl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(employeeListView);
            Controls.Add(editEmployeeBtn);
            Controls.Add(deleteEmployee);
            Controls.Add(addEmployeeBtn);
            Name = "EmployeeUIctl";
            Size = new Size(1200, 600);
            ResumeLayout(false);
        }

        #endregion

        private ListView employeeListView;
        private ColumnHeader name;
        private ColumnHeader email;
        private ColumnHeader phoneNumber;
        private ColumnHeader role;
        private ColumnHeader department;
        private Button editEmployeeBtn;
        private Button deleteEmployee;
        private Button addEmployeeBtn;
    }
}
