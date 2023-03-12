using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace librian_desktop.Data.MainDb.Users
{
    public interface IUserRepo 
    {
        Task<User> CreateUser(User user);
    }
}
