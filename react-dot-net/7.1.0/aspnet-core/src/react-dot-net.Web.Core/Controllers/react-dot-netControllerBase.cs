using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace react-dot-net.Controllers
{
    public abstract class react-dot-netControllerBase: AbpController
    {
        protected react-dot-netControllerBase()
        {
            LocalizationSourceName = react-dot-netConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
