using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace StackifySupport.EntityFrameworkCore
{
    public static class StackifySupportDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<StackifySupportDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<StackifySupportDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
