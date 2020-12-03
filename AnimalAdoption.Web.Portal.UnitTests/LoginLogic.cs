using AnimalAdoption.Common.Logic;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Linq;
using Xunit;

namespace AnimalAdoption.Service.Login.UnitTests
{
    public class LoginTests
    {
        [Fact]
        public void LoginManagement_LoginRequested()
        {
            var userId = "placeholder";

            var memoryCache = new MemoryCache(new MemoryCacheOptions());
            var resultingId = new LoginService().GetLoginUserFromId(userId);

            Assert.Equal("DevOps_Team3", resultingId);
        }
    }
}
