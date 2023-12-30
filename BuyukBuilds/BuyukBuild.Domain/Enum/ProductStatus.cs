using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BuyukBuild.Domain.Enum
{
    public enum ProductStatus
    {
        [EnumMember(Value ="active")]
        Active,
        [EnumMember(Value = "passive")]
        Passive
    }
}
