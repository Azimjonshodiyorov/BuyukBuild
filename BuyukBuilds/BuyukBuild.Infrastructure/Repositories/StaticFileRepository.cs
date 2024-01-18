using BuyukBuild.Domain.Entities.StaticFiles;
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
    public class StaticFileRepository : RepositoryBase<StaticFile, long> ,
        IStaticFileRepository
    {
        public StaticFileRepository(BuyukBuildDbContext context) 
            : base(context)
        {
        }
    }
}
