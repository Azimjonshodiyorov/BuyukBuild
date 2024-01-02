using BuyukBuild.Domain.Entities.Carts;
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
    public class CartRepository : RepositoryBase<Cart, long>, ICartRepository
    {
        public CartRepository(BuyukBuildDbContext context) 
            : base(context)
        {
        }
    }
}
