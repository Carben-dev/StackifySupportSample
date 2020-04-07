using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using StackifySupport.Authorization;

namespace StackifySupport
{
    [DependsOn(
        typeof(StackifySupportCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class StackifySupportApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<StackifySupportAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(StackifySupportApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
