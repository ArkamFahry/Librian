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
        Task<bool> CreateUserIndexAsync(UserIndex userIndex);

        Task<bool> UpdateUserIndexAsync(UserIndex userIndex);

        Task<bool> DeleteUserIndexAsync(string id);
        
        Task<IEnumerable<UserIndex>> SearchUserIndexAsync(string query);

        Task<UserIndex> GetUserIndexByIdAsync(string id);
    }
}
