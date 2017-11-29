using Pollify.Domain.Interface.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Pollify.Domain.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pollify.Infrastructure.Entities;

namespace Pollify.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private DbContext _context;

        public UserRepository(DbContext context)
        {
            _context = context;
        }
        public async Task<User> CreateUser(User user)
        {
            var entity = await _context.Set<UserEntity>().FirstOrDefaultAsync(u => u.Email == user.Email);
            if (entity != null) throw new Exception("Email already Exists");
            entity = user.ToEntity();
            _context.Set<UserEntity>().Add(entity);
            await _context.SaveChangesAsync();
            user.UserId = entity.UserId;
            return user;
        }

        public async Task DeleteUser(string id)
        {
            var entity = _context.Set<UserEntity>().Find(id);
            if (entity != null)
            {
                _context.Set<UserEntity>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<User> GetUserByEmail(string userName)
        {
            var user = await _context.Set<UserEntity>().FirstOrDefaultAsync(u => u.Email == userName);
            return user.Map();
        }

        public async Task<User> GetUserById(string userId)
        {
            var user = await _context.Set<UserEntity>().FindAsync(userId);
            return user.Map();
        }

        public async Task SetPassword(string id, string passwordHash)
        {
            if (id == null) throw new ArgumentNullException("Invalid User Id");
            var user = _context.Set<UserEntity>().Find(id);
            if (user == null) throw new Exception("User not Found");
            user.PasswordHash = passwordHash;
            await _context.SaveChangesAsync();
        }

        public Task<User> UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
