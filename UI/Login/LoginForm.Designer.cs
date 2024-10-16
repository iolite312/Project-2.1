namespace UI.Login
{
    partial class LoginForm
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
            TitleLbl = new Label();
            DescriptionLbl = new Label();
            UsernameLbl = new Label();
            PasswordLbl = new Label();
            PasswordTB = new TextBox();
            EmailTB = new TextBox();
            RememberMeCB = new CheckBox();
            ForgotLoginLLBL = new LinkLabel();
            LoginBtn = new Button();
            ErrorLbl = new Label();
            SuspendLayout();
            // 
            // TitleLbl
            // 
            TitleLbl.AutoSize = true;
            TitleLbl.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            TitleLbl.Location = new Point(46, 15);
            TitleLbl.Margin = new Padding(4, 0, 4, 0);
            TitleLbl.Name = "TitleLbl";
            TitleLbl.Size = new Size(324, 65);
            TitleLbl.TabIndex = 0;
            TitleLbl.Text = "NODESK: TGG";
            // 
            // DescriptionLbl
            // 
            DescriptionLbl.Location = new Point(46, 117);
            DescriptionLbl.Margin = new Padding(4, 0, 4, 0);
            DescriptionLbl.Name = "DescriptionLbl";
            DescriptionLbl.Size = new Size(334, 58);
            DescriptionLbl.TabIndex = 1;
            DescriptionLbl.Text = "Please provide login credentials to login to NoDesk for The Garden Group";
            DescriptionLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UsernameLbl
            // 
            UsernameLbl.AutoSize = true;
            UsernameLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            UsernameLbl.Location = new Point(46, 205);
            UsernameLbl.Margin = new Padding(4, 0, 4, 0);
            UsernameLbl.Name = "UsernameLbl";
            UsernameLbl.Size = new Size(145, 40);
            UsernameLbl.TabIndex = 2;
            UsernameLbl.Text = "Username";
            // 
            // PasswordLbl
            // 
            PasswordLbl.AutoSize = true;
            PasswordLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordLbl.Location = new Point(46, 328);
            PasswordLbl.Margin = new Padding(4, 0, 4, 0);
            PasswordLbl.Name = "PasswordLbl";
            PasswordLbl.Size = new Size(136, 40);
            PasswordLbl.TabIndex = 3;
            PasswordLbl.Text = "Password";
            // 
            // PasswordTB
            // 
            PasswordTB.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTB.Location = new Point(46, 375);
            PasswordTB.Margin = new Padding(4, 5, 4, 5);
            PasswordTB.Name = "PasswordTB";
            PasswordTB.PasswordChar = '*';
            PasswordTB.Size = new Size(324, 45);
            PasswordTB.TabIndex = 2;
            PasswordTB.TextChanged += PasswordTB_TextChanged;
            // 
            // EmailTB
            // 
            UsernameTB.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            UsernameTB.Location = new Point(46, 252);
            UsernameTB.Margin = new Padding(4, 5, 4, 5);
            UsernameTB.Name = "UsernameTB";
            UsernameTB.Size = new Size(324, 45);
            UsernameTB.TabIndex = 1;
            // 
            // RememberMeCB
            // 
            RememberMeCB.AutoSize = true;
            RememberMeCB.Location = new Point(46, 440);
            RememberMeCB.Margin = new Padding(4, 5, 4, 5);
            RememberMeCB.Name = "RememberMeCB";
            RememberMeCB.Size = new Size(154, 29);
            RememberMeCB.TabIndex = 4;
            RememberMeCB.Text = "Remember me";
            RememberMeCB.UseVisualStyleBackColor = true;
            // 
            // ForgotLoginLLBL
            // 
            ForgotLoginLLBL.AutoSize = true;
            ForgotLoginLLBL.LinkColor = Color.Blue;
            ForgotLoginLLBL.Location = new Point(209, 442);
            ForgotLoginLLBL.Margin = new Padding(4, 0, 4, 0);
            ForgotLoginLLBL.Name = "ForgotLoginLLBL";
            ForgotLoginLLBL.Size = new Size(175, 25);
            ForgotLoginLLBL.TabIndex = 5;
            ForgotLoginLLBL.TabStop = true;
            ForgotLoginLLBL.Text = "Forgot login details?";
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.FromArgb(46, 111, 64);
            LoginBtn.FlatStyle = FlatStyle.Flat;
            LoginBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LoginBtn.ForeColor = Color.White;
            LoginBtn.Location = new Point(46, 568);
            LoginBtn.Margin = new Padding(4, 5, 4, 5);
            LoginBtn.MinimumSize = new Size(326, 57);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(326, 57);
            LoginBtn.TabIndex = 3;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // ErrorLbl
            // 
            ErrorLbl.ForeColor = Color.FromArgb(192, 0, 0);
            ErrorLbl.Location = new Point(0, 483);
            ErrorLbl.Margin = new Padding(4, 0, 4, 0);
            ErrorLbl.Name = "ErrorLbl";
            ErrorLbl.Size = new Size(424, 75);
            ErrorLbl.TabIndex = 9;
            ErrorLbl.Text = "ErrorLbl";
            ErrorLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 647);
            Controls.Add(ErrorLbl);
            Controls.Add(LoginBtn);
            Controls.Add(ForgotLoginLLBL);
            Controls.Add(RememberMeCB);
            Controls.Add(EmailTB);
            Controls.Add(PasswordTB);
            Controls.Add(PasswordLbl);
            Controls.Add(UsernameLbl);
            Controls.Add(DescriptionLbl);
            Controls.Add(TitleLbl);
            Margin = new Padding(4, 5, 4, 5);
            Name = "LoginForm";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TitleLbl;
        private Label DescriptionLbl;
        private Label UsernameLbl;
        private Label PasswordLbl;
        private TextBox PasswordTB;
        private TextBox EmailTB;
        private CheckBox RememberMeCB;
        private LinkLabel ForgotLoginLLBL;
        private Button LoginBtn;
        private Label ErrorLbl;
    }
}