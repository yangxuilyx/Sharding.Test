using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Sharding.Test.Authorization.Roles;
using Sharding.Test.Authorization.Users;
using Sharding.Test.MultiTenancy;

namespace Sharding.Test.EntityFrameworkCore
{
    public class TestDbContext : AbpZeroDbContext<Tenant, Role, User, TestDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public TestDbContext(DbContextOptions<TestDbContext> options)
            : base(options)
        {
        }
    }
}
