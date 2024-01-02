using BuyukBuild.Domain.Entities.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukBuild.Infrastructure.Repositories.Interfaces
{
    public interface IEmployeeRepository : IRepositoryBase<Employee , long>
    {
    }
}
