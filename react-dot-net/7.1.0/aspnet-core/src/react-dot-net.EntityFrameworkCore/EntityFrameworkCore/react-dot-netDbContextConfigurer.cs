using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace react-dot-net.EntityFrameworkCore
{
    public static class react-dot-netDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<react-dot-netDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<react-dot-netDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
