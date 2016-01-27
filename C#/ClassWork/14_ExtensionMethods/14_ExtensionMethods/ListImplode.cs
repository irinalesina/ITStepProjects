using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_ExtensionMethods
{
    static class ListImplode
    {
        public static string Implode<T>(this IEnumerable<T> arr, string separator = ",")
        {
            StringBuilder res = new StringBuilder();

            foreach(var a in arr)
            {
                res.Append(a.ToString());
                res.Append(separator);
            }

            res.Remove(res.Length - 1, 1);

            return res.ToString();
        }
    }
}
