using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_ExtensionMethods
{
    static class CollectionsToJSON
    {
        public static string ListToJSON<T>(this IEnumerable<T> arr)
        {
            StringBuilder res = new StringBuilder();

            res.Append("[");

            foreach (var a in arr)
            {
                res.Append(a.ToString());
                res.Append(",");
            }

            res.Remove(res.Length - 1, 1);

            res.Append("]");

            return res.ToString();
        }


        public static string DictionaryToJSON<key, value>(this IDictionary<key, value> arr)
        {
            StringBuilder res = new StringBuilder();

            res.Append("{");

            foreach (var a in arr)
            {
                try
                {
                    int k = Int32.Parse(a.Key.ToString());
                    res.Append(k.ToString());
                }
                catch
                {
                    res.Append("'");
                    res.Append(a.Key.ToString());
                    res.Append("'");
                }


                res.Append(":");


                try
                {

                    int v = Int32.Parse(a.Value.ToString());
                    res.Append(v.ToString());
                }
                catch
                {
                    res.Append("'");
                    res.Append(a.Value.ToString());
                    res.Append("'");
                }

                res.Append(",");
            }

            res.Remove(res.Length - 1, 1);

            res.Append("}");

            return res.ToString();
        }

        
    }
}
