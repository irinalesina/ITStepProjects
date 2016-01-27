using System;
using System.Collections.Generic;

namespace _6_Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randon = new Random();

            int arr_size = 10;
            int[] arr = new int[arr_size];

            for (int i = 0; i < arr_size; i++)
            {
                arr[i] = randon.Next(0, 100);
            }

            Console.WriteLine("Current arr:");
            for (int i = 0; i < arr_size; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\n");


            DelegateMethod del = new DelegateMethod();
            

            Console.WriteLine("Arr after reduce:");
            Func d = x=>x/2;
            Map(arr, d);
            d = del.Output;
            Map(arr, d);
            Console.WriteLine("\n");

            Console.WriteLine("Arr after reset prime numb:");
            d = del.ResetPrimeNumber;
            Map(arr, d);
            d = del.Output;
            Map(arr, d);
            Console.WriteLine("\n");
            
            Console.WriteLine("Arr after squared:");
            Map(arr, x=>x*x);
            d = del.Output;
            Map(arr, d);
            Console.WriteLine("\n");


            Console.ReadKey();
        }

        public static int[] Map(int[] arr, Func d)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = d(arr[i]);
            }

            return arr;
        }

    }

    public delegate int Func(int a);

    public class DelegateMethod
    {
        public int Reduce(int x)
        {
            return x / 2;
        }

        public int Squared(int x)
        {
            return x * x;
        }

        public int ResetPrimeNumber(int x)
        {
            if(x % 2 == 0)
            {
                return x;
            }

            bool prime = true;
            for (int i = 3; i <= Math.Sqrt(x); i += 2)
            {
                if (x % i == 0)
                {
                    return x;
                }
            }

            return 0;
        }

        public int Output(int x)
        {
            Console.Write(x + " ");
            return x;
        }
    }

}
