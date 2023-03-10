using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using trackx_desktop.Models;
using System.Threading.Tasks;

namespace trackx_desktop.Services.LocalStore.Repo
{
    public interface IUserRepo
    {
        User GetUser();

        void SetUser (User user);

        void UpdateUser (User user);

        void DeleteUser ();
    }
}
