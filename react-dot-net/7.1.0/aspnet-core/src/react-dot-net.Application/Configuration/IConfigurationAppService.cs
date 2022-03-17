using System.Threading.Tasks;
using react-dot-net.Configuration.Dto;

namespace react-dot-net.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
