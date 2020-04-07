using System.Threading.Tasks;
using StackifySupport.Configuration.Dto;

namespace StackifySupport.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
