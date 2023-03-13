using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace librian_desktop.Data.MainDb.Roles
{
    public interface IRoleRepo
    {
        Task<IEnumerable<Role>> GetRolesAsync();
    }
}
