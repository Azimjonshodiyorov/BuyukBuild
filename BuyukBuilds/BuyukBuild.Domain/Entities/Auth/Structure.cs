using BuyukBuild.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace BuyukBuild.Domain.Entities.Auth
{
    [Table("structure" , Schema ="auth")]
    public class Structure : AuditableBaseEntity<long>
    {
        [Column("name")] public MultiLanguageField Name { get; set; }
        public virtual IEnumerable<User> Users { get; set; }
        public virtual IEnumerable<Permission> Permissions { get; set; }
        [Column("default")]
        public bool Default { get; set; }
    }
}
