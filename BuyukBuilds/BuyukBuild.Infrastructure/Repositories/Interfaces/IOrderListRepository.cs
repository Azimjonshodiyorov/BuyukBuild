using BuyukBuild.Domain.Entities.OrderLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukBuild.Infrastructure.Repositories.Interfaces
{
    public interface IOrderListRepository : IRepositoryBase<OrderList, long>
    {
    }
}
