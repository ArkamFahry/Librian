using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace librian_desktop.Data.MainDb.Users
{
    public interface IUserRepo 
    {
        Task<bool> CreateUser(User user);

        Task<bool> UpdateUser(User user);

        Task<bool> DeleteUser(User user);

        Task<User?> GetUserByEmail(string email);

        Task<User?> GetUserById(string id);
    }
}
