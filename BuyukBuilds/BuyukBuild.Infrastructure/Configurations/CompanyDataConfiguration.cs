using BuyukBuild.Domain.Entities.Company;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukBuild.Infrastructure.Configurations
{
    public class CompanyDataConfiguration : IEntityTypeConfiguration<CompanyData>
    {
        public void Configure(EntityTypeBuilder<CompanyData> builder)
        {
            builder
                .HasOne(x => x.Card)
                .WithOne(x => x.CompanyData)
                .HasForeignKey<CompanyData>(x => x.CardId);

            builder
                .HasOne(x => x.Address)
                .WithOne(x => x.CompanyData)
                .HasForeignKey<CompanyData>(x => x.AddresId);
        }
    }
}
