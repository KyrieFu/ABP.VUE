using Abp.Authorization;
using ABPStudy.MyProject.Authorization.Roles;
using ABPStudy.MyProject.Authorization.Users;

namespace ABPStudy.MyProject.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
