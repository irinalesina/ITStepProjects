using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    class Check
    {
        public SortedDictionary<string, int> soldProducts;
        double cash;
        Random rand = new Random();

        public Check()
        {
            List<string> productNames = new List<string>();
            cash = 0;
            foreach(var product in Shop.products)
            {
                productNames.Add(product.Key);
            }

            soldProducts = new SortedDictionary<string, int>();
            int typeProductCount = rand.Next(0, 10);
            for (int i = 0; i < typeProductCount; i++)
            {
                int productIndex = rand.Next(0, productNames.Count - 1);
                if (soldProducts.ContainsKey(productNames[productIndex]) == true)
                {
                    soldProducts[productNames[productIndex]] += rand.Next(0, 5);
                }
                else
                {
                    soldProducts.Add(productNames[productIndex], rand.Next(0, 5));
                }
            }

            foreach (var product in soldProducts)
            {
                cash += Shop.products[product.Key] * product.Value;
            }
        }

        public void Show()
        {
            Console.WriteLine("\nCheck:");
            foreach(var product in soldProducts)
            {
                Console.WriteLine("{0} - {1}", product.Key, product.Value);
            }

            Console.WriteLine("Cash: {0}\n", cash);
        }
    }
}
