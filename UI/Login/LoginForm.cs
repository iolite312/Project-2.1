using Model;
using Logic;
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
using UI.EmployeeUI;

namespace UI.Login
{
    public partial class LoginForm : Form
    {
        private int attempts;
        private readonly int maxAttempts;
        private LoginService loginService;
        private RememberMeService rememberMeService;
        public LoginForm()
        {
            InitializeComponent();
            maxAttempts = 3;
            InitiateStartupSequence();
            loginService = new LoginService();
            rememberMeService = new RememberMeService();
            RememberMeCheck();
        }


        //Click event when user clicks on login button
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ErrorLbl.Hide();
                Employee employee = Login(GetEmail(), GetPassword());
                if (employee == null)
                {
                    throw new Exception("Invalid username or password");
                }
                RememberMeOnLogin();
                redirect(employee);
            }
            catch (Exception ex) { ShowError(ex.Message.ToString()); adjustAttempts(ex.Message.ToString()); }
        }

        //Set startup parameters like a dissabled login button and hide the error label
        private void InitiateStartupSequence()
        {
            ErrorLbl.Visible = false;
            attempts = 0;
            DisableLoginButton();
        }

        // The login part
        private Employee Login(string Email, string Password)
        {
            return loginService.checkLogin(Email, Password);
        }

        //Returns username

        private string GetEmail()
        {
            return EmailTB.Text.ToString();
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

        //check if remember me was checked previously
        private void RememberMeOnLogin()
        {
            if (RememberMeCB.Checked)
            {
                loginService.SaveLoginDetails(GetEmail(), GetPassword());
            }
        }

        //Check if the file for the remember me exists
        private void RememberMeCheck()
        {
            if (rememberMeService.CheckIfFileExists())
            {
                loginWithRememberMe();
            }

        }

        //Tries to login with the details in the remember me file
        private void loginWithRememberMe()
        {
            try
            {
                EncryptionService encryptionService = new EncryptionService();
                RememberMe rememberMe = rememberMeService.LoadRememberMeData();
                if (rememberMe.GetValid())
                {
                    if (rememberMeService.CheckHardware(rememberMe))
                    {
                        Employee employee = Login(encryptionService.Decrypt(rememberMe.GetEmail(), rememberMe.GetKey(), rememberMe.GetIV()), encryptionService.Decrypt(rememberMe.GetPassword(), rememberMe.GetKey(), rememberMe.GetIV()));
                        if (employee == null)
                        {
                            throw new Exception("Invalid username or password");
                        }
                        redirect(employee);
                    }
                }
                else { rememberMeService.DeleteFile(); }
            }
            catch (Exception ex) { ShowError(ex.Message.ToString()); }
        }


        //Shows the error in the error label
        private void ShowError(string errorMessage)
        {
            ErrorLbl.Show(); ErrorLbl.Text = errorMessage;
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
                ErrorLbl.Text = message + "\n Systeem is locked. \n Restart to try again.";
            }
            else
            {
                ErrorLbl.Text = message + $"\n {maxAttempts - attempts} attempts left";
            }
        }

        //Lock the system when a user has exceded the maximum amount of tries
        private void LockDownSystem()
        {
            EmailTB.Enabled = false;
            PasswordTB.Enabled = false;
            DisableLoginButton();
        }

        //Enable the login button when a user enters a password
        private void PasswordTB_TextChanged(object sender, EventArgs e)
        {
            if (PasswordTB.Text != null) { EnableLoginButton(); }
            else { DisableLoginButton(); }
        }


        //Redirect the user to the dashboard
        private void redirect(Employee employee)
        {
            DashboardUI.Dashboard dashboard = new DashboardUI.Dashboard(employee);

            dashboard.Show();
            this.Hide();
        }

        //So it finally hides the form when a user is automaticly logged in :)
        private void LoginForm_Shown(object sender, EventArgs e)
        {
            if (!rememberMeService.CheckIfFileExists()) { return; }
            this.Hide();
        }
    }
}
