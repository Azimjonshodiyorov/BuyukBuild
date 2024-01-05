using BuyukBuild.Domain.Entities.Common;
using BuyukBuild.Domain.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace BuyukBuild.Domain.Entities.Auth.AuthMethods
{
    public abstract class AuthMethodBase : BaseEntity<long>
    {
        [Column("user_id"), ForeignKey(nameof(User))]
        public long UserId { get; set; }

        public virtual User User { get; set; }
        [Column("method_type")] 
        public AuthMethod MethodType { get; set; }
    }
}