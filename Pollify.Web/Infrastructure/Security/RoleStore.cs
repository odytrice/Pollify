﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;

namespace Pollify.Web.Infrastructure.Security
{
    public class RoleStore : IRoleStore<string>
    {
        public Task<IdentityResult> CreateAsync(string role, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<IdentityResult> DeleteAsync(string role, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            // Do Nothing
        }

        public Task<string> FindByIdAsync(string roleId, CancellationToken cancellationToken)
        {
            return Task.FromResult(roleId);
        }

        public Task<string> FindByNameAsync(string normalizedRoleName, CancellationToken cancellationToken)
        {
            return Task.FromResult(normalizedRoleName);
        }

        public Task<string> GetNormalizedRoleNameAsync(string role, CancellationToken cancellationToken)
        {
            return Task.FromResult(role);
        }

        public Task<string> GetRoleIdAsync(string role, CancellationToken cancellationToken)
        {
            return Task.FromResult(role);
        }

        public Task<string> GetRoleNameAsync(string role, CancellationToken cancellationToken)
        {
            return Task.FromResult(role);
        }

        public Task SetNormalizedRoleNameAsync(string role, string normalizedName, CancellationToken cancellationToken)
        {
            return Task.FromResult(role);
        }

        public Task SetRoleNameAsync(string role, string roleName, CancellationToken cancellationToken)
        {
            return Task.FromResult(role);
        }

        public Task<IdentityResult> UpdateAsync(string role, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
