using Api.Identity;
using Api.Tools;
using Logic;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace Api.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private const string jwtSecret = "ileFV2UT50Lcw2nLcpfYw8gRJHTi19asac";
        private static readonly TimeSpan tokenLifetime = TimeSpan.FromDays(1);
        private readonly LoginService _loginService;
        private readonly TokenGenerator _tokenGenerator;

        public AuthController()
        {
            _loginService = new LoginService();
            _tokenGenerator = new TokenGenerator();
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody]IdentityData data)
        {
            Employee employee = _loginService.checkLogin(data.Email, data.Password);
            if (employee == null)
            {
                return Unauthorized();
            }

            return _tokenGenerator.GenerateToken(employee, jwtSecret, tokenLifetime);

        }
    }
}
