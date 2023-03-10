using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trackx_desktop.Models;

namespace trackx_desktop.Services.LocalStore.Repo
{
    public interface IAuthRepo
    {
        Auth GetAuth();

        void SetAuth(Auth auth);

        void UpdateAuth (Auth auth);

        void DeleteAuth ();
    }
}
