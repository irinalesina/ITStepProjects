using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ZOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[5];

            animals[0] = new Cat("KUZYA");
            animals[1] = new Bird("GOSHA");
            animals[2] = new Bird("CARCUSHA");
            animals[3] = new Cat("NUSHA");
            animals[4] = new Bird("VASILIY");


            
            foreach(var an in animals)
            {
                try
                {
                    IFlier f = (IFlier)an;
                    
                    f.Fly();
                }
                catch(InvalidCastException)
                {
                    // nothing
                }
            }

            Console.ReadKey();
        }
    }
}
