using BuyukBuild.Domain.Entities.Auth.AuthMethods;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukBuild.Infrastructure.Configurations.AuthConfigurations
{
    public class PhoneBasedAuthMethodConfigurations : IEntityTypeConfiguration<PhoneBasedAuthMethod>
    {
        public void Configure(EntityTypeBuilder<PhoneBasedAuthMethod> builder)
        {
            builder
                .HasMany(x => x.Otps)
                .WithOne()
                .HasForeignKey(x => x.AuthMethodId);
        }
    }
}
