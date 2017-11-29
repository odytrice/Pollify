using Microsoft.AspNetCore.Identity;
using Pollify.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using Pollify.Domain.Interface.Repositories;

namespace Pollify.Web.Infrastructure.Security
{
    public class UserStore : IUserStore<UserModel>, IUserPasswordStore<UserModel>
    {
        private IUserRepository _repo;

        public UserStore(IUserRepository repo)
        {
            _repo = repo;
        }

        public async Task<IdentityResult> CreateAsync(UserModel user, CancellationToken cancellationToken)
        {
            var operation = await Operation.Run(async () =>
            {
                var newUser = await _repo.CreateUser(user.Map());
                user.Id = newUser.UserId;
            });

            return operation.ToIdentity();
        }

        public async Task<IdentityResult> DeleteAsync(UserModel user, CancellationToken cancellationToken)
        {
            var operation = await Operation.Run(async () =>
            {
                await _repo.DeleteUser(user.Id);
            });
            return operation.ToIdentity();
        }

        public void Dispose()
        {
            // Do Nothing
        }

        public async Task<UserModel> FindByIdAsync(string userId, CancellationToken cancellationToken)
        {
            var user = await _repo.GetUserById(userId);
            return user.Map();
        }

        public async Task<UserModel> FindByNameAsync(string normalizedUserName, CancellationToken cancellationToken)
        {
            var user = await _repo.GetUserByEmail(normalizedUserName);
            return user.Map();
        }

        public Task<string> GetNormalizedUserNameAsync(UserModel user, CancellationToken cancellationToken)
        {
            return Task.FromResult(user.UserName);
        }

        public Task<string> GetPasswordHashAsync(UserModel user, CancellationToken cancellationToken)
        {
            return Task.FromResult(user.PasswordHash);
        }

        public async Task<string> GetUserIdAsync(UserModel model, CancellationToken cancellationToken)
        {
            var user = await _repo.GetUserByEmail(model.UserName);
            return user?.UserId;
        }

        public Task<string> GetUserNameAsync(UserModel user, CancellationToken cancellationToken)
        {
            return Task.FromResult(user.Email);
        }

        public Task<bool> HasPasswordAsync(UserModel user, CancellationToken cancellationToken)
        {
            return Task.FromResult(true);
        }

        public Task SetNormalizedUserNameAsync(UserModel user, string normalizedName, CancellationToken cancellationToken)
        {
            return Task.FromResult(true);
        }

        public Task SetPasswordHashAsync(UserModel user, string passwordHash, CancellationToken cancellationToken)
        {
            return Task.FromResult(user.PasswordHash = passwordHash);
        }

        public Task SetUserNameAsync(UserModel user, string userName, CancellationToken cancellationToken)
        {
            return Task.FromResult(true);
        }

        public async Task<IdentityResult> UpdateAsync(UserModel user, CancellationToken cancellationToken)
        {
            var operation = await Operation.Run(async () =>
            {
                return await _repo.UpdateUser(user.Map());
            });

            return operation.ToIdentity();
        }
    }
}
