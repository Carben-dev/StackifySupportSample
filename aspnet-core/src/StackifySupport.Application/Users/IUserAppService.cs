using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using StackifySupport.Roles.Dto;
using StackifySupport.Users.Dto;

namespace StackifySupport.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
