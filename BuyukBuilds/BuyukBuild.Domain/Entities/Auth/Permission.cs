using BuyukBuild.Domain.Entities.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace BuyukBuild.Domain.Entities.Auth
{
    public class Permission : BaseEntity<long>
    {
        [Column("name")] public MultiLanguageField Name { get; set; }
        [Column("code")] public int Code { get; set; }
        public virtual IEnumerable<Structure> Structures { get; set; }
    }
}