using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using librian_desktop.Data.SearchDb.Models;
using librian_desktop.Data.SearchDb.Users;

namespace librian_desktop.Data.MainDb.Users
{
    public class UserRepo : IUserRepo
    {
        public async Task<User> CreateUser(User user)
        {
            user.Email = user.Email.ToLower();
            
            await using var lbContext = new LibrianContext();
            lbContext.Users.Add(user);
            await lbContext.SaveChangesAsync();

            var createdUser = lbContext.Users.Single(u => u.Id == user.Id);

            var indexUser = new UserIndexRepo();
            var iUser = new UserIndex
            {
                Id = createdUser.Id,
                Name = createdUser.Name,
                Email = createdUser.Email,
                CreatedAt = createdUser.CreatedAt,
                UpdatedAt = createdUser.UpdatedAt,
            };
            await indexUser.CreateUser(iUser);

            return createdUser;
        }
    }
}
