﻿using Abp.Dependency;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using EFCore.Sharding;
using Sharding.Test.Configuration;

namespace Sharding.Test.Web.Host.Startup
{
    [DependsOn(
       typeof(TestWebCoreModule))]
    public class TestWebHostModule : AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public TestWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
          
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TestWebHostModule).GetAssembly());
        }
    }
}
