using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MatrixThreading
{
    class Program
    {
        static int matrixSize = 200;
        static Random rand = new Random();

        static void Main(string[] args)
        {
            int[,] matrix1 = new int[matrixSize,matrixSize];
            for (int row = 0; row < matrixSize; row++)
                for (int col = 0; col < matrixSize; col++)
                    matrix1[row, col] = rand.Next(); // some value


            int[,] matrix2 = new int[matrixSize, matrixSize];
            for (int row = 0; row < matrixSize; row++)
                for (int col = 0; col < matrixSize; col++)
                    matrix2[row, col] = rand.Next(); // some value

            Console.WriteLine("SRC:");
            //PrintMatrix(matrix);


            int[,] res = MatrixMultiplication(matrix1, matrix2);

            Console.WriteLine("RES:");
            PrintMatrix(res);

            Console.ReadKey();
        }

        static void PrintMatrix(int[,] m)
        {
            for (int row = 0; row < matrixSize; row++)
            {
                for (int col = 0; col < matrixSize; col++)
                {
                    Console.Write("{0} ", m[row, col]);
                }
                Console.WriteLine();
            }
        }

        static int[,] MatrixMultiplication(int[,] m1, int [,] m2)
        {
            //// initial res matrix with "7"
            int[,] res = new int[matrixSize, matrixSize];
            //for (int row = 0; row < 100; row++)
            //    for (int col = 0; col < 100; col++)
            //        res[row, col] = 7; // some value

            // method
            List<Thread> threads = new List<Thread>();
            for (int row = 0; row < matrixSize; row++)
            {
                for (int col = 0; col < matrixSize; col++)
                {
                    int r, c;
                    r = row;
                    c = col;
                    Thread th = new Thread(() => ThreadAction(matrixSize, m1, m2, r, c, ref res));
                    threads.Add(th);
                    th.Start();
                    //ThreadAction(3, m1, m2, row, col, ref res);
                }
            }
            foreach (var thr in threads)
                thr.Join();

            return res;
        }

        static void ThreadAction(int size, int[,] m1, int[,] m2, int row1, int col2, ref int[,] res)
        {
           
            int result = 0;
            //    Console.WriteLine("TH: row={0} col={1}", row1, col2);
            //if (row1 >= size || col2 >= size)
            //{
            //    return;
            //}

            Thread.Sleep(1000);
            for(int i = 0, j = 0; i < size && j < size; i++, j++)
            {
                
                result += m1[row1, i] * m2[j, col2];
            }
            //Console.WriteLine("TH: row={0} col={1}", row1, col2);
            res[row1, col2] = result;
        }


    }
}
