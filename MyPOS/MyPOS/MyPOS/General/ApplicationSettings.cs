using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace MyPOS.General
{
    public class ApplicationSettings
    {
        public static string ConnectionString1()
        {
            return ConfigurationManager.ConnectionStrings["rbx"].ConnectionString;
        }

        public static string ConnectionString2()
        {
            return ConfigurationManager.ConnectionStrings["MyPOSContext"].ConnectionString;
        }

    }
}
