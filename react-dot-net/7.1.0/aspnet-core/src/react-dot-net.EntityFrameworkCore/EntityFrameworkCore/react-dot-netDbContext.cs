using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using react-dot-net.Authorization.Roles;
using react-dot-net.Authorization.Users;
using react-dot-net.MultiTenancy;

namespace react-dot-net.EntityFrameworkCore
{
    public class react-dot-netDbContext : AbpZeroDbContext<Tenant, Role, User, react-dot-netDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public react-dot-netDbContext(DbContextOptions<react-dot-netDbContext> options)
            : base(options)
        {
        }
    }
}
