using DAL;
using Model;
using Model.Enums;
using System.Text.Json.Serialization;

namespace Api.DTO
{
    public class EmployeeDTO
    {
        private Employee? _employee;

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Password { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ERole Role { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public EDepartment Department { get; set; }

        public EmployeeDTO ConvertModel(Employee employee)
        {
            _employee = employee;
            FirstName = employee.FirstName;
            LastName = employee.LastName;
            Email = employee.Email;
            PhoneNumber = employee.PhoneNumber;
            Role = employee.Role;
            Department = employee.Department;
            return this;
        }

        public Employee RevertModel()
        {
            if (_employee != null)
            {
                return _employee;
            }
            return new Employee(FirstName, LastName, Email, PhoneNumber, Role, "", "", Department);
        }
        public Employee RevertModel(string id)
        {
            if (_employee != null)
            {
                return _employee;
            }
            return new Employee(FirstName, LastName, Email, PhoneNumber, Role, "", "", Department, null, id);
        }
        public Employee RevertModel(string hashedPassword, string salt)
        {
            if (_employee != null)
            {
                return _employee;
            }
            return new Employee(FirstName, LastName, Email, PhoneNumber, Role, hashedPassword, salt, Department);
        }
    }
}
