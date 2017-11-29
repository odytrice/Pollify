using Pollify.Domain.Models;
using Pollify.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pollify.Infrastructure
{
    public static class Extensions
    {
        public static UserEntity ToEntity(this User user)
        {
            if (user == null) return null;
            return new UserEntity
            {
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Image = user.Image,
                PasswordHash = user.PasswordHash,
                UserId = user.UserId,
            };
        }

        public static User Map(this UserEntity userEntity)
        {
            if (userEntity == null) return null;
            return new User
            {
                Email = userEntity.Email,
                FirstName = userEntity.FirstName,
                Image = userEntity.Image,
                LastName = userEntity.LastName,
                PasswordHash = userEntity.PasswordHash,
                UserId = userEntity.UserId
            };
        }
    }
}
