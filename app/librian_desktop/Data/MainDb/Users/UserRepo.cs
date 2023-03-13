﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using librian_desktop.Data.SearchDb.Models;
using librian_desktop.Data.SearchDb.Users;
using Microsoft.EntityFrameworkCore;

namespace librian_desktop.Data.MainDb.Users
{
    public class UserRepo : IUserRepo
    {
        public async Task<bool> CreateUserAsync(User user)
        {
            user.Id = Guid.NewGuid().ToString();
            user.Email = user.Email.ToLower();
            user.CreatedAt = DateTime.Now;
            user.Role = "user";

            await using var lbContext = new LibrianContext();
            lbContext.Users.Add(user);
            await lbContext.SaveChangesAsync();

            var indexUser = new UserIndexRepo();
            var iUser = new UserIndex
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                Role = user.Role,
                AccessRevoked = user.AccessRevoked.ToString(),
                CreatedAt = user.CreatedAt.ToString(),
                UpdatedAt = user.UpdatedAt.ToString(),
            };
            await indexUser.CreateUserIndex(iUser);

            return true;
        }

        public async Task<bool> UpdateUserAsync(User user)
        {
            user.Email = user.Email.ToLower();
            user.UpdatedAt = DateTime.Now;

            await using var lbContext = new LibrianContext();
            lbContext.Users.Update(user);
            await lbContext.SaveChangesAsync();
            
            var indexUser = new UserIndexRepo();
            var iUser = new UserIndex
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                Role = user.Role,
                AccessRevoked = user.AccessRevoked.ToString(),
                CreatedAt = user.CreatedAt.ToString(),
                UpdatedAt = user.UpdatedAt.ToString(),
            };
            await indexUser.UpdateUserIndex(iUser);

            return true;
        }

        public async Task<bool> DeleteUserAsync(User user)
        {
            await using var lbContext = new LibrianContext();
            lbContext.Users.Remove(user);
            await lbContext.SaveChangesAsync();

            var indexUser = new UserIndexRepo();
            await indexUser.DeleteUserIndex(user.Id);

            return true;
        }

        public async Task<User?> GetUserByEmailAsync(string email)
        {
            email = email.ToLower();
            await using var lbContext = new LibrianContext();
            var user = await lbContext.Users.SingleOrDefaultAsync(e => e.Email == email);
            return user;
        }

        public async Task<User?> GetUserByIdAsync(string id)
        {
            await using var lbContext = new LibrianContext();
            var user = await lbContext.Users.SingleOrDefaultAsync(i => i.Id == id);
            return user;
        }
        
    }
}
