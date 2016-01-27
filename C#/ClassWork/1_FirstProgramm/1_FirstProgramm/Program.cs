using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyVector;

namespace _1_FirstProgramm
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector a = new Vector(0, 0, 1);
            Vector b = new Vector(1, 0, 0);

            Vector Add = Vector.Addition(a, b);
            a.Output();
            Console.Write(" + ");
            b.Output();
            Console.Write(" = ");
            Add.Output();


            Console.WriteLine("\nScalar product: ");
            a.Output();
            Console.Write(" * ");
            b.Output();
            Console.Write(" = ");
            Console.Write(Vector.ScalarProduct(a, b));


            Console.WriteLine("\nVector product: ");
            a.Output();
            Console.Write(" * ");
            b.Output();
            Console.Write(" = ");
            Vector res = Vector.VectorProduct(a, b);
            res.Output();


            Console.ReadKey();
        }
    }
}
