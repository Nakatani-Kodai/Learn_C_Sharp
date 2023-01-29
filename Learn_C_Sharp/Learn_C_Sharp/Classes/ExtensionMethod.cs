using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_C_Sharp.Classes
{
    public static class ExtensionMethod
    {
        public static string Hoge (this string str)
        {
            return str == "hoge" ? "It is hoge": "It is not hoge" ;
        }
    }
}
