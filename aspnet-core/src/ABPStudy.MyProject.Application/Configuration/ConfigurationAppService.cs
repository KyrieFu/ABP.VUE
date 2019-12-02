using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ABPStudy.MyProject.Configuration.Dto;

namespace ABPStudy.MyProject.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MyProjectAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
