using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggyUserStore_IntegrationTests.Utilities
{
    public class TestUser : IUser<string>
    {
        public string Id { get; set; }

        public string UserName { get; set; }
    }
}
