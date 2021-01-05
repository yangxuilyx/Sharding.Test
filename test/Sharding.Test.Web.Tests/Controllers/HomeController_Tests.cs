﻿using System.Threading.Tasks;
using Sharding.Test.Models.TokenAuth;
using Sharding.Test.Web.Controllers;
using Shouldly;
using Xunit;

namespace Sharding.Test.Web.Tests.Controllers
{
    public class HomeController_Tests: TestWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}