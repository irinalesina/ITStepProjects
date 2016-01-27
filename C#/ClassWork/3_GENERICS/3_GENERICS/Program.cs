using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_GENERICS
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            

            int arr_size = 15000;
            int[] arr = new int[arr_size];


            for(int i = 0; i < arr_size; i++)
            {
                arr[i] = random.Next(0, 2);
            }

            /*Console.WriteLine("Array before sort:");
            foreach(var i in arr)
                Console.Write("{0} ", i);*/


            int time = 0;
            Console.WriteLine("\nArray after BubbleSort:");
            Sort<int>.BubbleSort(arr, 0, arr_size, ref time);
            /*foreach (var i in Sort<int>.BubbleSort(arr, 0, arr_size, ref time))
                Console.Write("{0} ", i);*/
            Console.WriteLine("Compare count = {0} ", time);


            time = 0;
            Console.WriteLine("\nArray after QuickSort:");
            Sort<int>.QuickSort(arr, 0, arr_size - 1, ref time);
            /*foreach (var i in Sort<int>.QuickSort(arr, 0, arr_size - 1, ref time))
                Console.Write("{0} ", i);*/
            Console.WriteLine("Compare count = {0} ", time);

            Console.ReadKey();
        }
    }
}
