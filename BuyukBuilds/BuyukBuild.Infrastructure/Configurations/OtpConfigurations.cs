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
    public class OtpConfigurations : IEntityTypeConfiguration<Otp>
    {
        public void Configure(EntityTypeBuilder<Otp> builder)
        {
            builder
                .HasOne(x => x.AuthMethod)
                .WithMany()
                .HasForeignKey(x => x.AuthMethodId)
                .IsRequired();
        }
    }
}
