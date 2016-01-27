using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Animals
{
    class Cat : Animal
    {
        public Cat(string name) :
            base(name) { }

        override public void Voice()
        {
            Console.WriteLine(name + " says: Myau!");
        }
    }
}
