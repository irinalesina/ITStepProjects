using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {

        static void Main(string[] args)
        {
            if(args == null || args.Length  < 1)
            {
                throw new ArgumentNullException();
            }
            int numb = Convert.ToInt32(args[0]);
            if(numb == null)
            {
                throw new ArgumentException("not a numb");
            }
            if(numb < 1)
            {
                throw new ArgumentException("<1");
            }
            int res = 1;
            for(int i = 1; i <= numb; i++)
            {
                res *= i;
            }
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
