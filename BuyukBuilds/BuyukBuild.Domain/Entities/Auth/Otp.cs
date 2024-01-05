using BuyukBuild.Domain.Entities.Auth.AuthMethods;
using BuyukBuild.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukBuild.Domain.Entities.Auth
{
    [Table("otp" , Schema ="auth")]
    public class Otp : BaseEntity<long>
    {
        [Column("code")]
        public string Code { get; set; }
        [Column("uid")]
        public Guid Uid { get; set; }
        [Column("sent_at")]
        public DateTime SentAt { get; set; }
        [Column("verified_at")]
        public DateTime VerifiedAt { get; set; }
        [Column("verified")]
        public bool Verified { get; set; }
        [Column("auth_method_id")]
        public long AuthMethodId { get; set; }

        public virtual AuthMethodBase AuthMethod { get; set; }

    }
}
