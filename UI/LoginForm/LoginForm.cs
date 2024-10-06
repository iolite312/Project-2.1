using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.LoginForm
{
    public partial class LoginForm : Form
    {
        private int attempts;
        private readonly int maxAttempts;
        public LoginForm()
        {
            InitializeComponent();
            maxAttempts = 3;
            InitiateStartupSequence();
        }


        //Click event when user clicks on login button
        private void LoginBtn_Click(object sender, EventArgs e)
        {

        }

        //Set startup parameters like a dissabled login button and hide the error label

        private void InitiateStartupSequence()
        {
            ErrorLbl.Visible = false;
            attempts = 0;
            DisableLoginButton();
        }

        //Returns username

        private string GetUsername()
        {
            return UsernameTB.Text.ToString();
        }

        //returns password

        private string GetPassword()
        {
            return PasswordTB.Text.ToString();
        }

        //disable login button

        private void DisableLoginButton()
        {
            LoginBtn.Enabled = false;
        }

        //enable login button

        private void EnableLoginButton()
        {
            LoginBtn.Enabled = true;
        }

        //adjust attempts when user enters wrong username / password

        private void adjustAttempts(string message)
        {
            attempts++;
            ShowAttempts(message);
            if (attempts >= maxAttempts)
            {
                LockDownSystem();

            }
        }

        // actually show the attempts left :)

        private void ShowAttempts(string message)
        {
            if (attempts >= maxAttempts)
            {
                ErrorLbl.Text = message + "\n Systeem staat op slot. \n Start het systeem opnieuw op om weer te proberen.";
            }
            else
            {
                ErrorLbl.Text = message + $"\n {maxAttempts - attempts} pogingen over";
            }
        }

        //Lock the system when a user has exceded the maximum amount of tries

        private void LockDownSystem()
        {
            UsernameTB.Enabled = false;
            PasswordTB.Enabled = false;
            DisableLoginButton();
        }

        //Enable the login button when a user enters a password
        private void PasswordTB_TextChanged(object sender, EventArgs e)
        {
            if (PasswordTB.Text != null) {EnableLoginButton(); }
            else { DisableLoginButton(); }
        }
    }
}
