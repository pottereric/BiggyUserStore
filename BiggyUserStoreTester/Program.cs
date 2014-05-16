using BiggyUserStore;
using BiggyUserStore_IntegrationTests.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggyUserStoreTester
{
    class Program
    {
        private static UserStore<TestUser> _store;
        static void Main(string[] args)
        {
            _store = new UserStore<TestUser>();

            CreateUser();
            //GetUsers();

            Console.WriteLine("Press Any Key To Continue");
            Console.ReadKey();
        }

        async private static void GetUsers()
        {
            var user = await _store.FindByIdAsync("1");

            Console.WriteLine("The user name is {0}", user.UserName);
        }

        async public static void CreateUser()
        {
            
            await _store.CreateAsync(new TestUser() { Id = "1", UserName = "Fstallone" });
        }
    }
}
