using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukBuild.Domain.Entities.Auth.AuthMethods
{
    public class LoginPasswordBasedAuthMethod : AuthMethodBase
    {
        [Column("login")]
        public string Login { get; set; }
        [Column("Password")]
        public string Password { get; set; }
    }
}
