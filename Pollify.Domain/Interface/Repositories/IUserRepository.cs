using Pollify.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pollify.Domain.Interface.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetUserByEmail(string userName);
        Task SetPassword(string id, string passwordHash);
        Task<User> UpdateUser(User user);
        Task<User> GetUserById(string userId);
        Task DeleteUser(string id);
        Task<User> CreateUser(User user);
    }
}
