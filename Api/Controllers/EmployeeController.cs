using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using Model.Enums;
using Logic;
using Microsoft.AspNetCore.Authorization;
using Api.Identity;
using System.Net;
using Api.DTO;

namespace Api.Controllers
{
    [Authorize]
    [RequiresClaim("rolePermissions", ERole.ServiceDesk, ERole.Manager)]
    [Route("api/employee")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeService _employeeService;

        public EmployeeController() 
        { 
            _employeeService = new EmployeeService();
        }

        [HttpGet("all")]
        public IActionResult All()
        {
            List<Employee> list = _employeeService.GetEmployees();

            if (list == null || list.Count == 0)
            {
                Response.StatusCode = 404;
                return new JsonResult(new { message = "No users exists" });
            }
            return Ok(list);
        }

        [HttpPost("create")]
        public IActionResult Create([FromBody] EmployeeDTO employeeDTO)
        {
            EncryptionService encryptionService = new EncryptionService();
            string salt = encryptionService.GenerateRandomString(16);
            string hashedPassword = encryptionService.EncryptPassword(employeeDTO.Password, salt);

            Employee employee = employeeDTO.RevertModel(hashedPassword, salt);
            bool result = _employeeService.CreateEmployee(employee);

            if (!result)
            {
                Response.StatusCode = 400;
                return new JsonResult(new { message = "User with that email already exists" });
            }
            Response.StatusCode = 201;
            return new JsonResult(new { message = $"User {employee.FirstName} {employee.LastName} has been created" });

        }

        [HttpGet("{id}")]
        public IActionResult GetEmployee([FromRoute] string id)
        {
            Employee employee = _employeeService.GetEmployee(id);
            return Ok(employee);
        }

        [HttpPut("{id}/update")]
        public IActionResult UpdateEmployee([FromRoute] string id, [FromBody] EmployeeDTO employeeDTO)
        {
            try
            {
                _employeeService.UpdateEmployee(employeeDTO.RevertModel(id));
                Response.StatusCode = 201;
                return new JsonResult(new { message = "User has been updated" });
            }
            catch (ArgumentNullException)
            {
                Response.StatusCode = 404;
                return new JsonResult(new { message = "User not found or does not exist" });
            }
            catch (Exception)
            {
                Response.StatusCode = 500;
                return new JsonResult(new { message = "Internal Server Error" });
            }
        }

        [HttpDelete("{id}/delete")]
        public IActionResult DeleteEmployee([FromRoute] string id)
        {
            try
            {
                bool isSuccesful = _employeeService.DeleteEmployee(id).Result;

                if (isSuccesful)
                {
                    Response.StatusCode = 200;
                    return new JsonResult(new { message = "User Was deleted" });
                }
                Response.StatusCode = 404;
                return new JsonResult(new { message = "User not found or does not exist" });
            }
            catch (Exception) 
            {
                Response.StatusCode = 500;
                return new JsonResult(new { message = "Internal Server Error" });
            }
        }
    }
}
