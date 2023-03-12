using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using librian_desktop.Data.SearchDb.Models;

namespace librian_desktop.Data.SearchDb.Users
{
    public interface IUserIndexRepo
    {
        Task<bool> CreateUser(UserIndex user);

        Task<bool> UpdateUser(UserIndex user);

        Task<bool> DeleteUser(UserIndex user);
        
        Task<IEnumerable<UserIndex>> GetUsers(string query);
    }
}
