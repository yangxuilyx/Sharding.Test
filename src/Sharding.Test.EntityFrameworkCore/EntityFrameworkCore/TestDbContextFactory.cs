using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Sharding.Test.Configuration;
using Sharding.Test.Web;

namespace Sharding.Test.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class TestDbContextFactory : IDesignTimeDbContextFactory<TestDbContext>
    {
        public TestDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<TestDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            TestDbContextConfigurer.Configure(builder, configuration.GetConnectionString(TestConsts.ConnectionStringName));

            return new TestDbContext(builder.Options);
        }
    }
}
