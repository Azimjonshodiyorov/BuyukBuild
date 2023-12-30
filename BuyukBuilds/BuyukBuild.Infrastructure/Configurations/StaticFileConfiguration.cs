using BuyukBuild.Domain.Entities.StaticFiles;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukBuild.Infrastructure.Configurations
{
    public class StaticFileConfiguration : IEntityTypeConfiguration<StaticFile>
    {
        public void Configure(EntityTypeBuilder<StaticFile> builder)
        {
            builder
                .HasMany(x => x.Products)
                .WithOne(x => x.StaticFile)
                .HasForeignKey(x => x.StaticFilesId);
        }
    }
}
