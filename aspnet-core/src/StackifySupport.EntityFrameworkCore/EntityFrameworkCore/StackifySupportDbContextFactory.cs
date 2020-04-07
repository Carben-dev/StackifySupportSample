using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using StackifySupport.Configuration;
using StackifySupport.Web;

namespace StackifySupport.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class StackifySupportDbContextFactory : IDesignTimeDbContextFactory<StackifySupportDbContext>
    {
        public StackifySupportDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<StackifySupportDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            StackifySupportDbContextConfigurer.Configure(builder, configuration.GetConnectionString(StackifySupportConsts.ConnectionStringName));

            return new StackifySupportDbContext(builder.Options);
        }
    }
}
