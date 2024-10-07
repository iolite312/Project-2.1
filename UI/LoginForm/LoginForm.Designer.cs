namespace UI.LoginForm
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
            TitleLbl.Location = new Point(37, 12);
            TitleLbl.Name = "TitleLbl";
            TitleLbl.Size = new Size(268, 54);
            TitleLbl.TabIndex = 0;
            TitleLbl.Text = "NODESK: TGG";
            // 
            // DescriptionLbl
            // 
            DescriptionLbl.Location = new Point(37, 93);
            DescriptionLbl.Name = "DescriptionLbl";
            DescriptionLbl.Size = new Size(268, 47);
            DescriptionLbl.TabIndex = 1;
            DescriptionLbl.Text = "Please provide login credentials to login to NoDesk for The Garden Group";
            DescriptionLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UsernameLbl
            // 
            UsernameLbl.AutoSize = true;
            UsernameLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            UsernameLbl.Location = new Point(37, 164);
            UsernameLbl.Name = "UsernameLbl";
            UsernameLbl.Size = new Size(121, 32);
            UsernameLbl.TabIndex = 2;
            UsernameLbl.Text = "Username";
            // 
            // PasswordLbl
            // 
            PasswordLbl.AutoSize = true;
            PasswordLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordLbl.Location = new Point(37, 263);
            PasswordLbl.Name = "PasswordLbl";
            PasswordLbl.Size = new Size(111, 32);
            PasswordLbl.TabIndex = 3;
            PasswordLbl.Text = "Password";
            // 
            // PasswordTB
            // 
            PasswordTB.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTB.Location = new Point(37, 300);
            PasswordTB.Margin = new Padding(3, 4, 3, 4);
            PasswordTB.Name = "PasswordTB";
            PasswordTB.PasswordChar = '*';
            PasswordTB.Size = new Size(260, 39);
            PasswordTB.TabIndex = 4;
            PasswordTB.TextChanged += PasswordTB_TextChanged;
            // 
            // UsernameTB
            // 
            UsernameTB.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            UsernameTB.Location = new Point(37, 201);
            UsernameTB.Margin = new Padding(3, 4, 3, 4);
            UsernameTB.Name = "UsernameTB";
            UsernameTB.Size = new Size(260, 39);
            UsernameTB.TabIndex = 5;
            // 
            // RememberMeCB
            // 
            RememberMeCB.AutoSize = true;
            RememberMeCB.Location = new Point(37, 352);
            RememberMeCB.Margin = new Padding(3, 4, 3, 4);
            RememberMeCB.Name = "RememberMeCB";
            RememberMeCB.Size = new Size(129, 24);
            RememberMeCB.TabIndex = 6;
            RememberMeCB.Text = "Remember me";
            RememberMeCB.UseVisualStyleBackColor = true;
            // 
            // ForgotLoginLLBL
            // 
            ForgotLoginLLBL.AutoSize = true;
            ForgotLoginLLBL.LinkColor = Color.Blue;
            ForgotLoginLLBL.Location = new Point(167, 353);
            ForgotLoginLLBL.Name = "ForgotLoginLLBL";
            ForgotLoginLLBL.Size = new Size(146, 20);
            ForgotLoginLLBL.TabIndex = 7;
            ForgotLoginLLBL.TabStop = true;
            ForgotLoginLLBL.Text = "Forgot login details?";
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.FromArgb(214, 0, 255);
            LoginBtn.FlatStyle = FlatStyle.Flat;
            LoginBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LoginBtn.ForeColor = Color.White;
            LoginBtn.Location = new Point(37, 429);
            LoginBtn.Margin = new Padding(3, 4, 3, 4);
            LoginBtn.MinimumSize = new Size(261, 45);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(261, 45);
            LoginBtn.TabIndex = 8;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // ErrorLbl
            // 
            ErrorLbl.AutoSize = true;
            ErrorLbl.ForeColor = Color.FromArgb(192, 0, 0);
            ErrorLbl.Location = new Point(137, 392);
            ErrorLbl.Name = "ErrorLbl";
            ErrorLbl.Size = new Size(61, 20);
            ErrorLbl.TabIndex = 9;
            ErrorLbl.Text = "ErrorLbl";
            ErrorLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 496);
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
            Margin = new Padding(3, 4, 3, 4);
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