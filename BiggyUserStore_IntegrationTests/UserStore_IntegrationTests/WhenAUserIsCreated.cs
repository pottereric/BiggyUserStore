using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BiggyUserStore_IntegrationTests.Utilities;
using BiggyUserStore;
using System.Threading.Tasks;

namespace BiggyUserStore_IntegrationTests.UserStore_IntegrationTests
{
    [TestClass]
    public class WhenAUserIsCreated
    {
        [TestMethod]
        async public Task ThenItIsAddedToTheList()
        {
            var store = new UserStore<TestUser>();

            var user = new TestUser() { Id = "1", UserName = "FStallone" };

            await store.CreateAsync(user);

            var output = await store.FindByIdAsync("1");

            Assert.IsNotNull(output);
            Assert.AreEqual("FStallone", output.UserName);
        }
    }
}
