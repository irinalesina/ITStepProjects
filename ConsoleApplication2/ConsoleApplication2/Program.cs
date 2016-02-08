using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            
        }

        
    }

    class A
    {
        static int a;
        public A()
        {
            Console.WriteLine("non static A");
        }
         static A()
        {
            Console.WriteLine("static A");
        }
    }
    class B : A
    {
        static int b;
         static B()
        {
            Console.WriteLine("static B");
        }
        public B()
        {
            Console.WriteLine("non static B");
        }
    }



}
