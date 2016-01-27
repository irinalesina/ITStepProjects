using System;
using System.Collections.Generic;


/*
    Создать интерфейс и реализовать его в классе,
    позволяющий вычислять сумму и среднее арифметическое
    для некоторого множества 
*/






namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>() { 1, 2, 3 };

            Console.WriteLine(SetsMethods<int>.Summ(a));
            Console.WriteLine(SetsMethods<int>.Mean(a));

            Console.ReadKey();
        }
    }
}
