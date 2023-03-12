using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using librian_desktop.Data.MainDb;
using librian_desktop.Data.MainDb.Users;

namespace librian_desktop.Utils
{
    public class CheckIfEmailExits
    {
        public async Task<bool> EmailExits(string email)
        {
            var userRepo = new UserRepo();

            try
            {
                var exists = await userRepo.GetUserByEmail(email); 

                if (exists != null)
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
