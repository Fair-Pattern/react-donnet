using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using react-dot-net.EntityFrameworkCore;
using react-dot-net.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace react-dot-net.Web.Tests
{
    [DependsOn(
        typeof(react-dot-netWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class react-dot-netWebTestModule : AbpModule
    {
        public react-dot-netWebTestModule(react-dot-netEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(react-dot-netWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(react-dot-netWebMvcModule).Assembly);
        }
    }
}