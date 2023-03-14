using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace librian_desktop.Data.MainDb.Users
{
    public interface IUserRepo 
    {
        Task<bool> CreateUserAsync(User user);

        Task<bool> UpdateUserAsync(User user);

        Task<bool> DeleteUserAsync(User user);

        Task<User?> GetUserByEmailAsync(string email);

        Task<User?> GetUserByIdAsync(string id);

        Task<IEnumerable<User>> GetUsersByRole(string role);

        Task<IEnumerable<User>> GetAllUsersAsync();
    }
}
