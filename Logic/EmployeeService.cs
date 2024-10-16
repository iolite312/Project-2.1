using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class EmployeeService
    {
        EmployeeDAO employeeDAO;

        public EmployeeService()
        {
            employeeDAO = new EmployeeDAO();
        }

        public void CreateEmployee(Employee employee)
        {
            employeeDAO.CreateEmployee(employee);
        }
        
        public List<Employee> GetEmployees()
        {
            return employeeDAO.GetEmployees();
        }

        public Employee GetEmployee(string id)
        {
            return employeeDAO.GetEmployee(id);
        }

        public void UpdateEmployee(Employee employee)
        {
            employeeDAO.UpdateEmployee(employee);
        }

        public Task<bool> DeleteEmployee(Employee employee)
        {
            return employeeDAO.DeleteEmployee(employee);
        }
    }
}
