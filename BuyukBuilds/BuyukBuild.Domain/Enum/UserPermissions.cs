using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukBuild.Domain.Enum
{
    public enum UserPermissions
    {
        Create = 1000,
        Edit,
        Delete,

        #region Auth

        PermissionView = 1100,
        PermissionNameEdit = 1102,

        StructureView = 1200,
        StructureCreate = 1201,
        StructureEdit = 1202,
        StructureDelete = 1203,

        UserInfoView = 1300,
        UsersView = 1301,
        ChangeUserStructure = 1302

        #endregion
    }
}
