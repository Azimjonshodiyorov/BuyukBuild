using BuyukBuild.Domain.Entities.Auth;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukBuild.Infrastructure.Configurations
{
    public class StructureConfigurations : IEntityTypeConfiguration<Structure>
    {
        public void Configure(EntityTypeBuilder<Structure> builder)
        {
            builder
                .HasMany(x => x.Permissions)
                .WithMany(x => x.Structures)
                .UsingEntity<StructurePermission>();

            builder
                .Property(x => x.Default)
                .HasDefaultValue(false);
        }
    }
}
