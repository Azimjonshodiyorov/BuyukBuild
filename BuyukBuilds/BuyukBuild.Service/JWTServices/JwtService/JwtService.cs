using BuyukBuild.Domain.Entities.Auth;
using BuyukBuild.Service.JWTServices.JwtService.Interface;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Threading.Tasks;

namespace BuyukBuild.Service.JWTServices.JwtService
{
    public class JwtService : IJwtService
    {
        private readonly IOptions<JwtOptions> options;

        public JwtService(IOptions<JwtOptions> options) 
        {
            this.options = options;
        }



        public async Task<(string, DateTime)> GenerateToken()
        {
            var result = Guid.NewGuid();

            return ((Convert.ToBase64String(result.ToByteArray())), 
                (DateTime.UtcNow.AddMinutes(options.Value.ExpirationInMinutes)));
        }
        public async Task<string> GenerateAccesToken(User user)
        {
            var result = GetClaims(user);
            var authKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(options.Value.SecretKey));
            var jwtSecurity = new JwtSecurityToken(
                issuer: this.options.Value.Issuer,
                audience: this.options.Value.Audience,
                signingCredentials: new SigningCredentials(key: authKey, SecurityAlgorithms.HmacSha256),
                expires: DateTime.UtcNow.AddMinutes(this.options.Value.ExpirationRefreshTokenInMinutes),
                claims: result
                );

            var token = new  JwtSecurityTokenHandler().WriteToken(jwtSecurity);

            return token;
        }


        private ICollection<Claim> GetClaims(User user)
        {
            var claims = new List<Claim>()
            {
               new Claim("User Id", user.Id.ToString()),
               new Claim("First Name", user.FirstName),
               new Claim("Last Name" , user.LastName),
               new Claim("Phone Number" , user.PhoneNumber),
               new Claim("Email" , user.Email)
            };

            return claims;

        }

    }
}
