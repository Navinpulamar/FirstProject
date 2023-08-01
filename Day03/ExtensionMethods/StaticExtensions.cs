using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    internal static class StaticExtensions
    {
        //For integer
        public static bool isEven(this int value)
        {
            return value % 2 == 0;
        }

        //isNull or not
        public static bool isNull(this Employee obj)
        {
            if (obj == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
