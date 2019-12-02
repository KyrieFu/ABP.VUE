using System.Threading.Tasks;
using ABPStudy.MyProject.Configuration.Dto;

namespace ABPStudy.MyProject.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
