using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserGeneratorRU
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter amount of shoppers to add: ");

            DBConnector.AddShoppers(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("New shoppers were added!");

            Console.ReadKey();
        }
    }
}
