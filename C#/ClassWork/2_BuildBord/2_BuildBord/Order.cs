using System;
using System.Collections.Generic;




namespace _2_BuildBord
{
    class Order
    {
        public string name;
        public int clip_size;
        public int display_time;
        public OrderResult result;

        public Order(string order_name, int size_of_clip, int time_of_display)
        {
            name = order_name;
            clip_size = size_of_clip;
            display_time = time_of_display;
            result = new OrderResult();
        }
        public void ShouResult()
        {
            result.ShowResult(name);
        }

            
    }
}
