using System;



namespace _1_Animals
{
    class Dog : Animal
    {
        public Dog(string name) :
            base(name) { }

        override public void Voice()
        {
            Console.WriteLine(name + " says: Gav!");
        }
    }
}
