using Logic;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.EmployeeUI
{
    public partial class EmployeeUI : Form
    {
        private EmployeeService _employeeService;
        public EmployeeUI()
        {
            InitializeComponent();
            _employeeService = new EmployeeService();
            InitListView();
        }

        private void InitListView()
        {
            employeeListView.Items.Clear();
            List<Employee> employees = _employeeService.GetEmployees();

            foreach (Employee employee in employees)
            {
                ListViewItem item = new ListViewItem($"{employee.FirstName} {employee.LastName}");
                item.SubItems.Add(employee.Email);
                item.SubItems.Add(employee.PhoneNumber);
                item.SubItems.Add(employee.Role.ToString());
                item.SubItems.Add(employee.Department.ToString());
                item.Tag = employee;
                employeeListView.Items.Add(item);
            }
        }

        private void addEmployeeBtn_Click(object sender, EventArgs e)
        {
            EmployeeAddUI.EmployeeEditUI employeeAddUI = new EmployeeAddUI.EmployeeEditUI();
            employeeAddUI.ShowDialog();
            if (!employeeAddUI.canceled)
            {
                InitListView();
            }
        }

        private void deleteEmployee_Click(object sender, EventArgs e)
        {
            if (employeeListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a employee");
                return;
            }
            if (employeeListView.SelectedItems.Count > 1)
            {
                MessageBox.Show("Please only select one employee");
                return;
            }
            Employee employee = (Employee)employeeListView.SelectedItems[0].Tag;
            DialogResult result = MessageBox.Show("Are you sure you want to proceed? (This action is irreversible)", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                bool deletionResult = _employeeService.DeleteEmployee(employee.Id).Result;
                if (deletionResult)
                {
                    MessageBox.Show("Deletion was succesful");
                    InitListView();
                }
                else
                {
                    MessageBox.Show("Something went wrong please try again later");
                }
            }
        }

        private void editEmployeeBtn_Click(object sender, EventArgs e)
        {
            if (employeeListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a Employee");
                return;
            }
            if (employeeListView.SelectedItems.Count > 1)
            {
                MessageBox.Show("Please only select one employee");
                return;
            }
            EmployeeAddUI.EmployeeEditUI employeeAddUI = new EmployeeAddUI.EmployeeEditUI((Employee)employeeListView.SelectedItems[0].Tag, true);
            employeeAddUI.ShowDialog();
            if (!employeeAddUI.canceled)
            {
                InitListView();
            }
        }
    }
}
