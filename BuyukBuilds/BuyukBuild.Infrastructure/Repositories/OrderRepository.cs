using BuyukBuild.Domain.Entities.Orders;
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
    public class OrderRepository : RepositoryBase<Order, long>, IOrderRepository
    {
        public OrderRepository(BuyukBuildDbContext context)
            : base(context)
        {
        }
    }
}
