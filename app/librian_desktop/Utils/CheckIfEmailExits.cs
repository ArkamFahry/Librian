using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using librian_desktop.Data.MainDb;

namespace librian_desktop.Utils
{
    public class CheckIfEmailExits
    {
        public bool EmailExits(string email)
        {
            try
            {
                using var lbContext = new LibrianContext();
                var single = lbContext.Users.Single(e => e.Email == email);
                if (single != null)
                {
                    return true;
                }

                return false;
            }
            catch (NullReferenceException)
            {
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
