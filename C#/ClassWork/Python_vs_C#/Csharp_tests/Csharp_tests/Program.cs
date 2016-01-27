using System;
using System.Collections.Generic;
using System.IO;

namespace Csharp_tests
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(WritePrime(1000000));

            Console.ReadKey();
        }


        public static TimeSpan WritePrime(int max_numb)
        {
            DateTime before = DateTime.Now;

            using (StreamWriter writer = File.CreateText("../../prime.csv"))
            {
                for(int i = 3; i <= max_numb; i++)
                {
                    if(i.IsPrime() == true)
                    {
                        writer.WriteLine(i);
                    }
                }
            }

            DateTime after = DateTime.Now;

            return after.Subtract(before);
        }

        public static bool IsPrime(this int numb)
        {
            if(numb % 2 == 0)
            {
                return false;
            }

            for(int i = 3; i * i <= numb; i += 2)
            {
                if(numb % i == 0)
                {
                    //Console.WriteLine(i);
                    return false;
                }
            }

            return true;
        }

    }
}
