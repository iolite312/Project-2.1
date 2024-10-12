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
            UsernameTB = new TextBox();
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
            TitleLbl.Location = new Point(32, 9);
            TitleLbl.Name = "TitleLbl";
            TitleLbl.Size = new Size(218, 45);
            TitleLbl.TabIndex = 0;
            TitleLbl.Text = "NODESK: TGG";
            // 
            // DescriptionLbl
            // 
            DescriptionLbl.Location = new Point(32, 70);
            DescriptionLbl.Name = "DescriptionLbl";
            DescriptionLbl.Size = new Size(234, 35);
            DescriptionLbl.TabIndex = 1;
            DescriptionLbl.Text = "Please provide login credentials to login to NoDesk for The Garden Group";
            DescriptionLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UsernameLbl
            // 
            UsernameLbl.AutoSize = true;
            UsernameLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            UsernameLbl.Location = new Point(32, 123);
            UsernameLbl.Name = "UsernameLbl";
            UsernameLbl.Size = new Size(97, 25);
            UsernameLbl.TabIndex = 2;
            UsernameLbl.Text = "Username";
            // 
            // PasswordLbl
            // 
            PasswordLbl.AutoSize = true;
            PasswordLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordLbl.Location = new Point(32, 197);
            PasswordLbl.Name = "PasswordLbl";
            PasswordLbl.Size = new Size(91, 25);
            PasswordLbl.TabIndex = 3;
            PasswordLbl.Text = "Password";
            // 
            // PasswordTB
            // 
            PasswordTB.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTB.Location = new Point(32, 225);
            PasswordTB.Name = "PasswordTB";
            PasswordTB.PasswordChar = '*';
            PasswordTB.Size = new Size(228, 33);
            PasswordTB.TabIndex = 4;
            PasswordTB.TextChanged += PasswordTB_TextChanged;
            // 
            // UsernameTB
            // 
            UsernameTB.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            UsernameTB.Location = new Point(32, 151);
            UsernameTB.Name = "UsernameTB";
            UsernameTB.Size = new Size(228, 33);
            UsernameTB.TabIndex = 5;
            // 
            // RememberMeCB
            // 
            RememberMeCB.AutoSize = true;
            RememberMeCB.Location = new Point(32, 264);
            RememberMeCB.Name = "RememberMeCB";
            RememberMeCB.Size = new Size(104, 19);
            RememberMeCB.TabIndex = 6;
            RememberMeCB.Text = "Remember me";
            RememberMeCB.UseVisualStyleBackColor = true;
            // 
            // ForgotLoginLLBL
            // 
            ForgotLoginLLBL.AutoSize = true;
            ForgotLoginLLBL.LinkColor = Color.Blue;
            ForgotLoginLLBL.Location = new Point(146, 265);
            ForgotLoginLLBL.Name = "ForgotLoginLLBL";
            ForgotLoginLLBL.Size = new Size(114, 15);
            ForgotLoginLLBL.TabIndex = 7;
            ForgotLoginLLBL.TabStop = true;
            ForgotLoginLLBL.Text = "Forgot login details?";
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.FromArgb(46, 111, 64);
            LoginBtn.FlatStyle = FlatStyle.Flat;
            LoginBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LoginBtn.ForeColor = Color.White;
            LoginBtn.Location = new Point(32, 341);
            LoginBtn.MinimumSize = new Size(228, 34);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(228, 34);
            LoginBtn.TabIndex = 8;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // ErrorLbl
            // 
            ErrorLbl.ForeColor = Color.FromArgb(192, 0, 0);
            ErrorLbl.Location = new Point(0, 290);
            ErrorLbl.Name = "ErrorLbl";
            ErrorLbl.Size = new Size(297, 45);
            ErrorLbl.TabIndex = 9;
            ErrorLbl.Text = "ErrorLbl";
            ErrorLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(297, 388);
            Controls.Add(ErrorLbl);
            Controls.Add(LoginBtn);
            Controls.Add(ForgotLoginLLBL);
            Controls.Add(RememberMeCB);
            Controls.Add(UsernameTB);
            Controls.Add(PasswordTB);
            Controls.Add(PasswordLbl);
            Controls.Add(UsernameLbl);
            Controls.Add(DescriptionLbl);
            Controls.Add(TitleLbl);
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
        private TextBox UsernameTB;
        private CheckBox RememberMeCB;
        private LinkLabel ForgotLoginLLBL;
        private Button LoginBtn;
        private Label ErrorLbl;
    }
}