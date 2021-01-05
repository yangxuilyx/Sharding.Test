using System;
using System.Collections.Generic;
using EFCore.Sharding;
using Microsoft.EntityFrameworkCore;
using Sharding.Test.Students;

namespace Sharding.Test.EntityFrameworkCore
{
    public class CustomeDbContext : GenericDbContext
    {
        public CustomeDbContext(DbContextOptions contextOptions, DbContextParamters paramter, EFCoreShardingOptions shardingOptions) : base(contextOptions, paramter, shardingOptions)
        {
            var types = new List<Type>()
            {
                typeof(Student)
            };

            Paramter.EntityTypes = types.ToArray();
        }

        public CustomeDbContext(GenericDbContext dbContext) : base(dbContext)
        {
        }
    }
}