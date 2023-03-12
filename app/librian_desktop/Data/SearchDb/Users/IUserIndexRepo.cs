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
        Task<bool> CreateUserIndex(UserIndex user);

        Task<bool> UpdateUserIndex(UserIndex user);

        Task<bool> DeleteUserIndex(string id);
        
        Task<IEnumerable<UserIndex>> SearchUserIndex(string query);

        Task<UserIndex> GetUserIndexById(string id);
    }
}
