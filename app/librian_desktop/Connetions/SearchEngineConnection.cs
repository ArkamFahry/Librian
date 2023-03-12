using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace librian_desktop.Connetions
{
    public class SearchEngineConnection
    {
        public static string Url => ConfigurationManager.ConnectionStrings["SearchEngineUrl"].ConnectionString;

        public static string MasterKey =>
            ConfigurationManager.ConnectionStrings["SearchEngineMasterKey"].ConnectionString;
    }
}
