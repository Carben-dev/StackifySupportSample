using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace StackifySupport.Controllers
{
    public abstract class StackifySupportControllerBase: AbpController
    {
        protected StackifySupportControllerBase()
        {
            LocalizationSourceName = StackifySupportConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
