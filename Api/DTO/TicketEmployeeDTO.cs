using Model.Enums;
using Model;
using System.Text.Json.Serialization;

namespace Api.DTO
{
    public class TicketEmployeeDTO
    {
        public string Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ERole Role { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public EDepartment Department { get; set; }

        public TicketEmployeeDTO ConvertModel(Employee employee)
        {
            Id = employee.Id;
            FirstName = employee.FirstName;
            LastName = employee.LastName;   
            Email = employee.Email;
            Role = employee.Role;
            Department = employee.Department;
            return this;
        }

        public Employee RevertModel()
        {
            return new Employee(FirstName, LastName, Email, Role, Department, null, Id);
        }
    }
}
