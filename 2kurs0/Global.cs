using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursproga
{
    static class Global
    {
        private static string _globalVar = "";
        private static string _globalPerms = "";
        public static string GlobalVar
        {
            get { return _globalVar; }
            set { _globalVar = value; }
        }
        public static string GlobalPerms
        {
            get { return _globalPerms; }
            set { _globalPerms = value; }
        }
    }
}
