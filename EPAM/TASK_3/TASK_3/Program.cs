using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> stack = new MyStack<int>(10);

            Console.WriteLine("Pushing stack:");
            for(int i = 0 ; i < 10; i++)
            {
                Console.Write("{0}, ", i);
                stack.Push(i);
            }
            Console.WriteLine();
            Console.WriteLine("Size of stack = {0}", stack.GetSize());

            //stack.Push(20);

            Console.WriteLine("Poping stack:");
            for(int i = 0 ; i < 10; i++)
                Console.Write("{0}, ", stack.Pop());
            Console.WriteLine();

            Console.WriteLine("Size of stack = {0}", stack.GetSize());

            //stack.Pop();

            Console.ReadKey();
        }
    }
}
