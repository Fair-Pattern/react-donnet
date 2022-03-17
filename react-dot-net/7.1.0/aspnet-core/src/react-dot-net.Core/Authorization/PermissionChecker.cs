using Abp.Authorization;
using react-dot-net.Authorization.Roles;
using react-dot-net.Authorization.Users;

namespace react-dot-net.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
