using System.Threading.Tasks;
using Abp.Application.Services;
using StackifySupport.Authorization.Accounts.Dto;

namespace StackifySupport.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
