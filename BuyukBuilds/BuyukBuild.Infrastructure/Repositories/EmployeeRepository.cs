using BuyukBuild.Domain.Entities.Employees;
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
    public class EmployeeRepository : RepositoryBase<Employee, long>, IEmployeeRepository
    {
        public EmployeeRepository(BuyukBuildDbContext context) 
            : base(context)
        {
        }
    }
}
