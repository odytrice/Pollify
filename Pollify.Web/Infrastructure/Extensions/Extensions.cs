using Microsoft.AspNetCore.Identity;
using Pollify.Domain.Models;
using Pollify.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pollify.Web
{
    public static class Extensions
    {
        public static IdentityResult ToIdentity<T>(this Operation<T> operation)
        {
            if (operation.Succeeded)
            {
                return IdentityResult.Success;
            }
            else
            {
                return IdentityResult.Failed(new[] { new IdentityError { Code = "Operation Error", Description = operation.Message } });
            }
        }
    }

    public static class Mapper
    {
        public static User Map(this UserModel userModel)
        {
            if (userModel == null) return null;
            return new User
            {
                Email = userModel.UserName,
                PasswordHash = userModel. PasswordHash,
                UserId = userModel.Id,
            };
        }

        public static UserModel Map(this User user)
        {
            if (user == null) return null;
            return new UserModel
            {
                Id = user.UserId,
                UserName = user.Email,
                Email = user.Email,
                PasswordHash = user.PasswordHash
            };
        }
    }
}
