using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using react-dot-net.Configuration;

namespace react-dot-net.Web.Host.Startup
{
    [DependsOn(
       typeof(react-dot-netWebCoreModule))]
    public class react-dot-netWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public react-dot-netWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(react-dot-netWebHostModule).GetAssembly());
        }
    }
}
