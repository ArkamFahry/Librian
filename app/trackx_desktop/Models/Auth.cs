using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trackx_desktop.Models
{
    public class Auth
    {
        public int Id { get; set; }

        public string IdToken { get; set; }

        public string AccessToken { get; set; }

        public string RefreshToken { get; set; }

        public long Expiry { get; set; }
    }
}
