using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using StackifySupport.Configuration.Dto;

namespace StackifySupport.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : StackifySupportAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
