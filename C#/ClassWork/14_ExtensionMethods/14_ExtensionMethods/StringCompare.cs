using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace _14_ExtensionMethods
{
    public static class StringCompare
    {
        public static bool MoreThen(this string str1, string str2)
        {
            int i = String.Compare(str1, str2,new CultureInfo("en-US"), CompareOptions.Ordinal);
            return i > 0 ? true : false;
        }

        public static bool LessThen(this string str1, string str2)
        {
            int i = String.Compare(str1, str2, new CultureInfo("en-US"), CompareOptions.Ordinal);
            return i < 0 ? true : false;
        }

    }
}
