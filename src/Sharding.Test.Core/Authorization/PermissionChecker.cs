using Abp.Authorization;
using Sharding.Test.Authorization.Roles;
using Sharding.Test.Authorization.Users;

namespace Sharding.Test.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
