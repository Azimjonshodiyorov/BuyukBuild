using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukBuild.Domain.Entities.Common
{
    public class AuditableBaseEntity<T> : BaseEntity<T>
    {
        [Column("create_at")]
        public DateTime CreateAt { get; init; }
        [Column("update_at")]
        public DateTime UpdateAt { get; set; }
    }
}
