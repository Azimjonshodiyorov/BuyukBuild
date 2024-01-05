using BuyukBuild.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukBuild.Domain.Entities.Auth
{
    public class StructurePermission  : AuditableBaseEntity<long>
    {
        [Column("structure_id")]
        public long StructureId { get; set; }
        [Column("permission_id")]
        public long PermissionId { get; set; }
    }
}
