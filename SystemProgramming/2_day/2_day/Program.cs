using System;
using System.Threading;

namespace _2_day
{
    class Program
    {
        static int n = 0;
        static int threadName = 1;
    
        public static void Start()
        {
            Thread thread = new Thread(Func);
            thread.Name = (threadName++).ToString();
            thread.Start();
        }

        static void Func()
        {
            for(int i = 0; i < 10; i++)
            {
                n++;
            }
            Console.WriteLine("{0}: {1}", Thread.CurrentThread.Name, n);
        }

        static void Main(string[] args)
        {
            Program.Start();
            Program.Start();
            Console.WriteLine("Main{0}", Program.n);

            Console.ReadKey();
        }
    }
}
