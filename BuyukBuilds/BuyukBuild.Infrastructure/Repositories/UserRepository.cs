using BuyukBuild.Domain.Entities.Auth;
using BuyukBuild.Infrastructure.DataContext;
using BuyukBuild.Infrastructure.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukBuild.Infrastructure.Repositories
{
    public class UserRepository : RepositoryBase<User, long>, IUserRepository
    {
        public UserRepository(BuyukBuildDbContext context) 
            : base(context)
        {
        }
    }
}
