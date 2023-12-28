using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BuyukBuild.Domain.Enum
{
    public enum UserRole
    {
        [EnumMember(Value ="Admin")]
        Admin,
        [EnumMember(Value = "SupperAdmin")]
        SupperAdmin,
        [EnumMember(Value ="Client")]
        Client,
        [EnumMember(Value = "Employee")]
        Employee,
    }
}
