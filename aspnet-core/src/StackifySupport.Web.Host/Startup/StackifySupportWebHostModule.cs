using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using StackifySupport.Configuration;

namespace StackifySupport.Web.Host.Startup
{
    [DependsOn(
       typeof(StackifySupportWebCoreModule))]
    public class StackifySupportWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public StackifySupportWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(StackifySupportWebHostModule).GetAssembly());
        }
    }
}
