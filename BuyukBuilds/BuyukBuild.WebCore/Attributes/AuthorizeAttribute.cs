using BuyukBuild.Domain.Enum;
using BuyukBuild.WebCore.Filters;
using Microsoft.AspNetCore.Mvc;

namespace BuyukBuild.WebCore.Attributes
{
    public class AuthorizeAttribute : TypeFilterAttribute
    {
        public AuthorizeAttribute(params UserPermissions[] permissions)
            : base(typeof(PermissionRequirementFilter))
        {
            this.Arguments = new object[]
            {
                permissions.Cast<int>().ToArray()
            };
        }
    }
}
