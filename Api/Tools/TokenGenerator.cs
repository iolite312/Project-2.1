using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Model;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Api.Tools
{
    public class TokenGenerator
    {
        public IActionResult GenerateToken(Employee employee, string jwtSecret, TimeSpan tokenLifetime)
        {
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

            return new OkObjectResult(handler.WriteToken(token));
        }
    }
}
