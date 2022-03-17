using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using react-dot-net.Configuration;
using react-dot-net.Web;

namespace react-dot-net.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class react-dot-netDbContextFactory : IDesignTimeDbContextFactory<react-dot-netDbContext>
    {
        public react-dot-netDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<react-dot-netDbContext>();
            
            /*
             You can provide an environmentName parameter to the AppConfigurations.Get method. 
             In this case, AppConfigurations will try to read appsettings.{environmentName}.json.
             Use Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") method or from string[] args to get environment if necessary.
             https://docs.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli#args
             */
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            react-dot-netDbContextConfigurer.Configure(builder, configuration.GetConnectionString(react-dot-netConsts.ConnectionStringName));

            return new react-dot-netDbContext(builder.Options);
        }
    }
}
