using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using react-dot-net.Configuration.Dto;

namespace react-dot-net.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : react-dot-netAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
