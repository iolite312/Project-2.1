using Api.Identity;
using Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Model;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Api.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private const string jwtSecret = "ileFV2UT50Lcw2nLcpfYw8gRJHTi19asac";
        private static readonly TimeSpan tokenLifetime = TimeSpan.FromDays(1);
        private readonly LoginService _loginService;

        public AuthController()
        {
            _loginService = new LoginService();
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody]IdentityData data)
        {
            Employee employee = _loginService.checkLogin(data.Email, data.Password);
            if (employee == null) 
            {
                return Unauthorized();
            }

            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
            byte[] key = Encoding.UTF8.GetBytes(jwtSecret);

            List<Claim> claims = new List<Claim> 
            { 
                new(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new(JwtRegisteredClaimNames.Iss, "www.id.gardengroup.com"),
                new(JwtRegisteredClaimNames.Aud, "www.gardengroup.com"),
                new(JwtRegisteredClaimNames.Sub, employee.Email),
                new(JwtRegisteredClaimNames.Email, employee.Email),
                new("userid", employee.Id),
                new("rolePermissions", employee.Role.ToString()),
            };

            SecurityTokenDescriptor tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.Add(tokenLifetime),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256)
            };

            SecurityToken token = handler.CreateToken(tokenDescriptor);

            return Ok(handler.WriteToken(token));

        }
    }
}
