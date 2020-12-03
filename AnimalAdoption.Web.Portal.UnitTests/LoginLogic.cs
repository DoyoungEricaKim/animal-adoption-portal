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
            var userId = "user1";

            var memoryCache = new MemoryCache(new MemoryCacheOptions());
            var resultingId = new LoginService(memoryCache, new AnimalService()).GetLoginUserFromId(userId);

            Assert.Equal("user1", resultingId);
        }
    }
}
