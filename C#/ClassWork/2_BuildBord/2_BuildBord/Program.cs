using System;
using System.Collections.Generic;




namespace _2_BuildBord
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderQueue order_queue = new OrderQueue();

            Order order1 = new Order("1.mp4", 2, 120);
            order_queue.AddToQueue(order1);

            Order order2 = new Order("2.mp4", 4, 100);
            order_queue.AddToQueue(order2);

            Order order3 = new Order("3.mp4", 10, 180);
            order_queue.AddToQueue(order3);

            Order order4 = new Order("4.mp4", 20, 80);
            order_queue.AddToQueue(order4);

            TV tv1 = new TV("tv1", 1300);
            //TV tv2 = new TV("tv2", 1300);

            tv1.DownloadQueue(order_queue);
            tv1.BeginPlayQueue();

            order1.ShouResult();
            Console.WriteLine();

            order2.ShouResult();
            Console.WriteLine();

            order3.ShouResult();
            Console.WriteLine();

            order4.ShouResult();
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            tv1.ShowStatistic();

            Console.ReadKey();

        }
    }
}
