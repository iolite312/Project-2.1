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

namespace UI.Login
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
            try
            {
                ErrorLbl.Hide();
                LoginService loginService = new LoginService();
                Employee employee = loginService.checkLogin(GetEmail(), GetPassword());
                if (employee == null)
                {
                    throw new Exception("Invalid username or password");
                }
                redirect(employee);
            }
            catch (Exception ex) { ErrorLbl.Show(); ErrorLbl.Text = ex.Message.ToString(); adjustAttempts(ex.Message.ToString()); }
        }

        //Set startup parameters like a dissabled login button and hide the error label

        private void InitiateStartupSequence()
        {
            ErrorLbl.Visible = false;
            attempts = 0;
            DisableLoginButton();
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

        private void redirect(Employee employee)
        {
            DashboardUI.Dashboard dashboard = new DashboardUI.Dashboard(employee);
            
            dashboard.Show();
            this.Hide();
            //switch (employee.Role)
            //{
            //    case Model.Enums.ERole.Employee:
            //        Form1 form1 = new Form1();
            //        form1.Show();
            //        //Go to employee form
            //        return;
            //    case Model.Enums.ERole.ServiceDesk:
            //        Form1 form2 = new Form1();
            //        form2.Show();
            //        //go to service desk form
            //        return;
            //    case Model.Enums.ERole.Manager:
            //        Form1 form3 = new Form1();
            //        form3.Show();
            //        //Go to manager form
            //        return;
            //    default:
            //        Form1 form4 = new Form1();
            //        form4.Show();
            //        return;
            //}
        }
    }
}
