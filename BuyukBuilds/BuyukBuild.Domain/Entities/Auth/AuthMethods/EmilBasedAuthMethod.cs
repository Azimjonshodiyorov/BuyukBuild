using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukBuild.Domain.Entities.Auth.AuthMethods
{
    public class EmilBasedAuthMethod : AuthMethodBase
    {
        public string Email { get; set; }
        public virtual ICollection<Otp> Otps { get; set; }
    }
}
