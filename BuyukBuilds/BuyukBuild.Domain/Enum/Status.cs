using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BuyukBuild.Domain.Enum
{
    public enum Status
    {
        [EnumMember(Value ="created")]
        Created,
        [EnumMember(Value ="updated")]
        Updated,
        [EnumMember(Value ="deleted")]
        Deleted,
    }
}
