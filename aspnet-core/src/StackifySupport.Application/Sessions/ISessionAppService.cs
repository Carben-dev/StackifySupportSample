using System.Threading.Tasks;
using Abp.Application.Services;
using StackifySupport.Sessions.Dto;

namespace StackifySupport.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
