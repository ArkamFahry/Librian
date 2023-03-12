using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace librian_desktop.Connetions
{
    public class DbConnection
    {
        public static string ConnectionString => ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
    }
}
