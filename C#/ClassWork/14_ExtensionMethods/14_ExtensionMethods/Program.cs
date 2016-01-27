using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_ExtensionMethods
{
    class Program
    {

        public class Test
        {
            public int integer;
            public string str;
            //public enum color { R, G, B };

            public Test(int i, string s)
            {
                this.integer = i;
                this.str = s;
            }

        }


        static void Main(string[] args)
        {
            string s1 = "A", s2 = "a";
            Console.WriteLine(s1.MoreThen(s2));
            Console.WriteLine(s1.LessThen(s2));

            List<int> arr = new List<int> { 1, 2, 3 };
            Console.WriteLine(arr.Implode());
            Console.WriteLine(arr.ListToJSON());


            Dictionary<int, char> vocabulary = new Dictionary<int, char>();

            for (int i = 65; i < 70; i++)
            {
                vocabulary.Add(i, Convert.ToChar(i));
            }

            Console.WriteLine(vocabulary.DictionaryToJSON());


            Test test = new Test(10, "abc");
            Console.WriteLine(test.ClassToJSON());


            Console.ReadKey();
        }
    }
}
