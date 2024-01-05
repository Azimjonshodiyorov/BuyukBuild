using BuyukBuild.Domain.Entities.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukBuild.Service.JWTServices.JwtService.Interface
{
    public interface IJwtService
    {
        Task<(string, DateTime)> GenerateToken();

        Task<string> GenerateAccesToken(User user);
    }
}
