using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arr
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = { { 2, 4, 6, 8},
                              { 2, 4, 6, 8},
                              { 2, 4, 6, 8},
                              { 2, 4, 6, 8} };
            int a = matrix.GetLength(0);
            int b = matrix.Length;
        }
    }
}
