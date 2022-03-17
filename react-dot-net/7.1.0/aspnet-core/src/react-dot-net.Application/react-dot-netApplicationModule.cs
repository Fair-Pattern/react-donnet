using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using react-dot-net.Authorization;

namespace react-dot-net
{
    [DependsOn(
        typeof(react-dot-netCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class react-dot-netApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<react-dot-netAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(react-dot-netApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
