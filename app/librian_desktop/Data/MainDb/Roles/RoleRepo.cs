using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace librian_desktop.Data.MainDb.Roles
{
    public class RoleRepo : IRoleRepo
    {
        public async Task<IEnumerable<Role>> GetRolesAsync()
        {
            await using var lbContext = new LibrianContext();
            var roles = lbContext.Roles.ToArray();

            return roles;
        }
    }
}
