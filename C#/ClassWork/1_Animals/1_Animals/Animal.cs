using System;



namespace _1_Animals
{
    abstract class Animal
    {
        protected readonly string name;
        public Animal(string name)
        {
            this.name = name;
        }
        public abstract void Voice();
    }
}
