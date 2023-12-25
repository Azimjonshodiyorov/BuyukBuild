using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukBuild.Domain.Entities.Auth
{
    public class JwtOptions
    {
        [Column("issuer")] 
        public string Issuer { get; set; }
        [Column("audience")] 
        public string Audience { get; set; }
        [Column("secret_key")] 
        public string SecretKey { get; set; }
        [Column("expiration_in_minutes")] 
        public double ExpirationInMinutes { get; set; }

        [Column("expiration_refresh_token_in_minutes")]
        public double ExpirationRefreshTokenInMinutes { get; set; }
    }
}
