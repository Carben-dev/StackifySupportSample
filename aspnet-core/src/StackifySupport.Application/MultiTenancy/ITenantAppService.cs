using Abp.Application.Services;
using Abp.Application.Services.Dto;
using StackifySupport.MultiTenancy.Dto;

namespace StackifySupport.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

