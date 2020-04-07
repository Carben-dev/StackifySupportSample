using Abp.Authorization;
using StackifySupport.Authorization.Roles;
using StackifySupport.Authorization.Users;

namespace StackifySupport.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
