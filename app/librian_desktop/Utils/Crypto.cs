using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace librian_desktop.Utils
{
    public class Crypto
    {
        public string HashPassword(string password)
        {
            var hash = BCrypt.Net.BCrypt.HashPassword(password);
            return hash;
        }

        public bool VerifyPassword(string password, string hash)
        {
            var verify = BCrypt.Net.BCrypt.Verify(password, hash);
            return verify;
        }
    }
}
