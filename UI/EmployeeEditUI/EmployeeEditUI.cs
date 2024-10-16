using Logic;
using Model;
using Model.Enums;

namespace UI.EmployeeAddUI
{
    public partial class EmployeeEditUI : Form
    {
        public bool canceled = false;
        private bool _isEditing = false;
        private Employee _employee;
        public EmployeeEditUI()
        {
            InitializeComponent();
            FillComboboxes();
        }
        public EmployeeEditUI(Employee employee, bool editing)
        {
            InitializeComponent();
            FillComboboxes();
            _employee = employee;
            _isEditing = editing;
            LoadForm();
        }

        private void FillComboboxes()
        {
            departmentInput.Items.Clear();
            roleInput.Items.Clear();

            foreach (EDepartment eDepartment in Enum.GetValues(typeof(EDepartment)))
            {
                departmentInput.Items.Add(eDepartment);
            }

            foreach (ERole eRole in Enum.GetValues(typeof(ERole)))
            {
                roleInput.Items.Add(eRole);
            }
        }

        private void phoneNumberInput_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(phoneNumberInput.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                phoneNumberInput.Text = phoneNumberInput.Text.Remove(phoneNumberInput.Text.Length - 1);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            canceled = true;
            Close();
        }

        private void createEmployeeBtn_Click(object sender, EventArgs e)
        {
            EncryptionService encryptionService = new EncryptionService();
            EmployeeService employeeService = new EmployeeService();

            if (firstNameInput.Text == "" || lastNameInput.Text == "" || emailInput.Text == "" || phoneNumberInput.Text == "" || departmentInput.SelectedItem == null || roleInput.SelectedItem == null || passwordInput.Text == "" || passwordRepeatInput.Text == "null")
            {
                MessageBox.Show("Please fill in all the fields"); return;
            }

            if (_isEditing)
            {
                Employee updatedEmployee = new Employee(firstNameInput.Text, lastNameInput.Text, emailInput.Text, "+31" + phoneNumberInput.Text, (ERole)roleInput.SelectedItem, _employee.Salt, _employee.HashedPassword, (EDepartment)departmentInput.SelectedItem, null, _employee.Id);
                if (EditConfirmation())
                {
                    employeeService.UpdateEmployee(updatedEmployee);
                    MessageBox.Show("Updated employee");
                } else
                {
                    canceled = true;
                }
            } else
            {
                string salt = encryptionService.GenerateRandomString(16);
                string hashedPassword = encryptionService.EncryptPassword(passwordInput.Text, salt);
                if (hashedPassword != encryptionService.EncryptPassword(passwordRepeatInput.Text, salt))
                {
                    MessageBox.Show("The passwords are not the same"); return;
                }
                Employee newEmployee = new Employee(firstNameInput.Text, lastNameInput.Text, emailInput.Text, "+31" + phoneNumberInput.Text, (ERole)roleInput.SelectedItem, salt, hashedPassword, (EDepartment)departmentInput.SelectedItem);
                employeeService.CreateEmployee(newEmployee);
                MessageBox.Show("Created employee");
            }
            Close();
        }
        private void LoadForm()
        {
            firstNameInput.Text = _employee.FirstName;
            lastNameInput.Text = _employee.LastName;
            emailInput.Text = _employee.Email;
            phoneNumberInput.Text = _employee.PhoneNumber.Replace("+31", "");
            departmentInput.SelectedItem = _employee.Department;
            roleInput.SelectedItem = _employee.Role;
            passwordInput.Text = "Placeholder";
            passwordRepeatInput.Text = "Placeholder";
            confirmEmployeeBtn.Text = "Update Employee";
            passwordInput.Visible = false;
            passwordRepeatInput.Visible = false;
            passwordLbl.Visible = false;
            passwordRepeatLbl.Visible = false;
        }
        private bool EditConfirmation()
        {
            DialogResult result = MessageBox.Show("Are you sure you want to proceed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
