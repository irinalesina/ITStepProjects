using System;
using System.Collections.Generic;
using System.Runtime.InteropServices; 


namespace TestMyDLL
{

    class Program
    {

        [DllImport("../../MyDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int MultiplyByTen(int numb); 

        static void Main(string[] args)
        {
            int a = MultiplyByTen(5);

            Console.WriteLine(a);


            Console.ReadKey();
        }
    }
}
