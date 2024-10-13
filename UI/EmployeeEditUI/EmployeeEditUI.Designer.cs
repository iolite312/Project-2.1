namespace UI.EmployeeAddUI
{
    partial class EmployeeEditUI
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
            label1 = new Label();
            label2 = new Label();
            firstNameInput = new TextBox();
            lastNameInput = new TextBox();
            label3 = new Label();
            emailInput = new TextBox();
            label4 = new Label();
            phoneNumberInput = new TextBox();
            label5 = new Label();
            passwordInput = new TextBox();
            passwordLbl = new Label();
            passwordRepeatInput = new TextBox();
            passwordRepeatLbl = new Label();
            roleInput = new ComboBox();
            departmentInput = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            confirmEmployeeBtn = new Button();
            cancelBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 74);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 0;
            label1.Text = "First Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(140, 28);
            label2.TabIndex = 1;
            label2.Text = "Add Employee";
            // 
            // firstNameInput
            // 
            firstNameInput.Location = new Point(129, 71);
            firstNameInput.Name = "firstNameInput";
            firstNameInput.Size = new Size(177, 27);
            firstNameInput.TabIndex = 2;
            // 
            // lastNameInput
            // 
            lastNameInput.Location = new Point(129, 104);
            lastNameInput.Name = "lastNameInput";
            lastNameInput.Size = new Size(177, 27);
            lastNameInput.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 107);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 3;
            label3.Text = "Last Name:";
            // 
            // emailInput
            // 
            emailInput.Location = new Point(129, 137);
            emailInput.Name = "emailInput";
            emailInput.Size = new Size(177, 27);
            emailInput.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(73, 140);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 5;
            label4.Text = "Email:";
            // 
            // phoneNumberInput
            // 
            phoneNumberInput.Location = new Point(129, 170);
            phoneNumberInput.Name = "phoneNumberInput";
            phoneNumberInput.Size = new Size(177, 27);
            phoneNumberInput.TabIndex = 8;
            phoneNumberInput.TextChanged += phoneNumberInput_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 173);
            label5.Name = "label5";
            label5.Size = new Size(111, 20);
            label5.TabIndex = 7;
            label5.Text = "Phone Number:";
            // 
            // passwordInput
            // 
            passwordInput.Location = new Point(452, 137);
            passwordInput.Name = "passwordInput";
            passwordInput.PasswordChar = '*';
            passwordInput.Size = new Size(125, 27);
            passwordInput.TabIndex = 10;
            // 
            // passwordLbl
            // 
            passwordLbl.AutoSize = true;
            passwordLbl.Location = new Point(373, 140);
            passwordLbl.Name = "passwordLbl";
            passwordLbl.Size = new Size(73, 20);
            passwordLbl.TabIndex = 9;
            passwordLbl.Text = "Password:";
            // 
            // passwordRepeatInput
            // 
            passwordRepeatInput.Location = new Point(452, 170);
            passwordRepeatInput.Name = "passwordRepeatInput";
            passwordRepeatInput.PasswordChar = '*';
            passwordRepeatInput.Size = new Size(125, 27);
            passwordRepeatInput.TabIndex = 12;
            // 
            // passwordRepeatLbl
            // 
            passwordRepeatLbl.AutoSize = true;
            passwordRepeatLbl.Location = new Point(325, 173);
            passwordRepeatLbl.Name = "passwordRepeatLbl";
            passwordRepeatLbl.Size = new Size(121, 20);
            passwordRepeatLbl.TabIndex = 11;
            passwordRepeatLbl.Text = "Repeat Password";
            // 
            // roleInput
            // 
            roleInput.FormattingEnabled = true;
            roleInput.Location = new Point(452, 103);
            roleInput.Name = "roleInput";
            roleInput.Size = new Size(151, 28);
            roleInput.TabIndex = 13;
            // 
            // departmentInput
            // 
            departmentInput.FormattingEnabled = true;
            departmentInput.Location = new Point(452, 69);
            departmentInput.Name = "departmentInput";
            departmentInput.Size = new Size(151, 28);
            departmentInput.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(404, 107);
            label8.Name = "label8";
            label8.Size = new Size(42, 20);
            label8.TabIndex = 15;
            label8.Text = "Role:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(354, 72);
            label9.Name = "label9";
            label9.Size = new Size(92, 20);
            label9.TabIndex = 16;
            label9.Text = "Department:";
            // 
            // confirmEmployeeBtn
            // 
            confirmEmployeeBtn.Location = new Point(354, 248);
            confirmEmployeeBtn.Name = "confirmEmployeeBtn";
            confirmEmployeeBtn.Size = new Size(165, 29);
            confirmEmployeeBtn.TabIndex = 17;
            confirmEmployeeBtn.Text = "Create Employee";
            confirmEmployeeBtn.UseVisualStyleBackColor = true;
            confirmEmployeeBtn.Click += createEmployeeBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(525, 248);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(78, 29);
            cancelBtn.TabIndex = 18;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // EmployeeEditUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 289);
            Controls.Add(cancelBtn);
            Controls.Add(confirmEmployeeBtn);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(departmentInput);
            Controls.Add(roleInput);
            Controls.Add(passwordRepeatInput);
            Controls.Add(passwordRepeatLbl);
            Controls.Add(passwordInput);
            Controls.Add(passwordLbl);
            Controls.Add(phoneNumberInput);
            Controls.Add(label5);
            Controls.Add(emailInput);
            Controls.Add(label4);
            Controls.Add(lastNameInput);
            Controls.Add(label3);
            Controls.Add(firstNameInput);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EmployeeEditUI";
            Text = "EmployeeAddUI";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox firstNameInput;
        private TextBox lastNameInput;
        private Label label3;
        private TextBox emailInput;
        private Label label4;
        private TextBox phoneNumberInput;
        private Label label5;
        private TextBox passwordInput;
        private Label passwordLbl;
        private TextBox passwordRepeatInput;
        private Label passwordRepeatLbl;
        private ComboBox roleInput;
        private ComboBox departmentInput;
        private Label label8;
        private Label label9;
        private Button confirmEmployeeBtn;
        private Button cancelBtn;
    }
}