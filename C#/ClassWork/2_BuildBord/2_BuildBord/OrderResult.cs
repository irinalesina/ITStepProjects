using System;
using System.Collections.Generic;




namespace _2_BuildBord
{
    class OrderResult
    {
        public struct pair
        {
            public string where_played;
            public int time;

            public pair(string where, int when_time)
            {
                where_played = where;
                time = when_time;
            }
        };
        public List<pair> result_table;


        public OrderResult() { result_table = new List<pair>(); }
        public void AddToOrderResult(string where, int when_time)
        {
            result_table.Add(new pair(where, when_time));
        }
        public void ShowResult(string order_name)
        {
            for (int i = 0; i < result_table.Count; i++)
            {
                Console.WriteLine("{0}\n{1} : {2}", order_name,
                    result_table[i].time, result_table[i].where_played);
            }
        }
    }
}
