using System;




namespace _1_Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat Barsik = new Cat("Barsik");
            Dog Bobik = new Dog("Bobik");

            Barsik.Voice();
            Bobik.Voice();

            Console.ReadKey();
        }
    }
}
