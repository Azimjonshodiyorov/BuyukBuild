using BuyukBuild.Domain.Entities.Company;
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
    public class CompanyRepository : RepositoryBase<CompanyData, long>, ICompanyRepository
    {
        public CompanyRepository(BuyukBuildDbContext context) 
            : base(context)
        {
        }
    }
}
