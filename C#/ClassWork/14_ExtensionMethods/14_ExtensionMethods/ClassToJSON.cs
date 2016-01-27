using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _14_ExtensionMethods
{
    static class ClasstoJSON
    {
        public static string ClassToJSON<T>(this T obj)
        {
            StringBuilder res = new StringBuilder();

            res.Append("{\n");

            try
            {
                // Get the type handle of a specified class.
                Type myType = typeof(T);

                // Get the fields of the specified class.
                FieldInfo[] myField = myType.GetFields();

                for (int i = 0; i < myField.Length; i++)
                {
                    res.Append(myField[i].Name);
                    res.Append(" = ");
                    res.Append(myField[i].GetValue(obj));
                    res.Append(",\n");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception : {0} ", e.Message);
            }
            

            res.Remove(res.Length - 1, 1);

            res.Append("\n}");

            return res.ToString();
        }
    }
}
