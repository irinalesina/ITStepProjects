using System;
using System.Collections.Generic;
using System.Threading;



namespace Event
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();

            shop.Opening += shop_Opening;
            shop.Closing += shop_Closing;


            shop.Open();
            Thread.Sleep(5000);
            shop.Close();

            Console.ReadKey();
        }

        static void shop_Closing(object sender, ShopEventArgs e)
        {
            Console.WriteLine(e.Message);
        }

        static void shop_Opening(object sender, ShopEventArgs e)
        {
            Console.WriteLine(e.Message);
        }


        
    }
}
