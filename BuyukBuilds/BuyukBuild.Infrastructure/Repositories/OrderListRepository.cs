using BuyukBuild.Domain.Entities.OrderLists;
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
    public class OrderListRepository : RepositoryBase<OrderList, long>, IOrderListRepository
    {
        public OrderListRepository(BuyukBuildDbContext context) 
            : base(context)
        {
        }
    }
}
