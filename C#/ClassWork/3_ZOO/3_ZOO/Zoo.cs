using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ZOO
{

    interface IFlier
    {
        void Fly();
        /*{
            Console.WriteLine("fly!");
        }*/
    }
    class Animal
    {
        protected string name;

        public Animal() { }
        public Animal(string animal_name)
        {
            name = animal_name;
        }
    }

    class Cat : Animal
    {
        public Cat(string name) : base(name) { }
        
    }

    class Bird : Animal, IFlier
    {
        public Bird(string name) : base(name) { }

        public void Fly()
        {
            Console.WriteLine("{0} is fly!", name);
        }
    }






}
