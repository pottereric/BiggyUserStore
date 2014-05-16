using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biggy;
using Biggy.JSON;
using Microsoft.AspNet.Identity;

namespace BiggyUserStore
{
    public class UserStore<TUser> : IUserStore<TUser>, IUserStore<TUser, string>, IUserPasswordStore<TUser>, IUserPasswordStore<TUser, string>, IUserRoleStore<TUser>, IUserRoleStore<TUser, string>, IDisposable where TUser : class, IUser<string>, new() 
    {
        private BiggyList<TUser> _backingStore;

        public UserStore()
        {
            _backingStore = new BiggyList<TUser>(new JsonStore<TUser>());
        }

        public Task CreateAsync(TUser user)
        {
            _backingStore.Add(user);

            return Task.FromResult(0);
        }

        public Task DeleteAsync(TUser user)
        {
            throw new NotImplementedException();
        }

        public Task<TUser> FindByIdAsync(string userId)
        {
            var user = _backingStore.Where(u => u.Id == userId).SingleOrDefault();

            return Task.FromResult(user);
        }

        public Task<TUser> FindByNameAsync(string userName)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(TUser user)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<string> GetPasswordHashAsync(TUser user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> HasPasswordAsync(TUser user)
        {
            throw new NotImplementedException();
        }

        public Task SetPasswordHashAsync(TUser user, string passwordHash)
        {
            throw new NotImplementedException();
        }

        public Task AddToRoleAsync(TUser user, string roleName)
        {
            throw new NotImplementedException();
        }

        public Task<IList<string>> GetRolesAsync(TUser user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsInRoleAsync(TUser user, string roleName)
        {
            throw new NotImplementedException();
        }

        public Task RemoveFromRoleAsync(TUser user, string roleName)
        {
            throw new NotImplementedException();
        }
    }
}
