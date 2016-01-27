using System;
using System.Collections.Generic;




namespace _2_BuildBord
{
    class OrderQueue
    {
        public List<Order> orders;
        int time_count;


        public OrderQueue()
        { 
            orders = new List<Order>();
            time_count = 0;
        }

        public void AddToQueue(Order order)
        {
            orders.Add(order);
            time_count += order.display_time;
        }

        public bool Show(string TV_name)
        {
            //...
            return true;
        }

    }
}
