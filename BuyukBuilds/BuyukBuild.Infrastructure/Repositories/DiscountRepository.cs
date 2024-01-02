using BuyukBuild.Domain.Entities.Discounts;
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
    public class DiscountRepository : RepositoryBase<Discount, long>, IDiscountRepository
    {
        public DiscountRepository(BuyukBuildDbContext context) 
            : base(context)
        {
        }
    }
}
