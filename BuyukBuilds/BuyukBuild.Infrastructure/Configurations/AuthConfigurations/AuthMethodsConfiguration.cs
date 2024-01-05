using BuyukBuild.Domain.Entities.Auth.AuthMethods;
using BuyukBuild.Domain.Enum;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukBuild.Infrastructure.Configurations.AuthConfigurations
{
    public class AuthMethodsConfiguration : IEntityTypeConfiguration<AuthMethodBase>
    {
        public void Configure(EntityTypeBuilder<AuthMethodBase> builder)
        {
            builder
            .UseTphMappingStrategy()
                .HasDiscriminator(x => x.MethodType)
                .HasValue<EmilBasedAuthMethod>(AuthMethod.EmailBased)
                .HasValue<PhoneBasedAuthMethod>(AuthMethod.PhoneBased)
                .HasValue<LoginPasswordBasedAuthMethod>(AuthMethod.LoginPasswordBased)
                .IsComplete();
        }
    }
}
