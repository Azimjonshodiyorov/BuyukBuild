using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukBuild.Domain.Entities.Auth.AuthMethods
{
    public class PhoneBasedAuthMethod : AuthMethodBase
    {
        [Column("phone_number")]
        public string PhoneNumber { get; set; }

        public virtual ICollection<Otp> Otps { get; set; }
    }
}
