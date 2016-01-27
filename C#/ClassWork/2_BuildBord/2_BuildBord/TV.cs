using System;
using System.Collections.Generic;




namespace _2_BuildBord
{
    class TV
    {
        private string name;
        private OrderQueue current_queue;
        private OrderQueue play_queue;
        int current_time;

        SortedDictionary<string, int> statistic;


        public TV(string tv_name, int time)
        {
            name = tv_name;
            current_time = time;

            statistic = new SortedDictionary<string, int>();
        }

        public void DownloadQueue(OrderQueue queue)
        {
            current_queue = queue;
            for(int i = 0; i < queue.orders.Count; i++)
            {
                statistic.Add(queue.orders[i].name, 0);
            }
        }

        public bool SetPlayQueue(List<string> play_elements)
        {
            for (int i = 0; i < play_elements.Count; i++ )
            {
                for(int j = 0; j < current_queue.orders.Count; j++)
                {
                    if(play_elements[i] == current_queue.orders[j].name)
                    {
                        play_queue.AddToQueue(current_queue.orders[j]);
                    }
                }
            }

            return BeginPlayQueue();
        }

        
        public void ShowStatistic()
        {
            foreach(var s in statistic)
            {
                Console.WriteLine("{0}\n{1} : {2}", name, s.Key, s.Value);
            }
        }


        public bool BeginPlayQueue()
        {
            while (current_queue.orders.Count != 0)
            {
                for (int i = 0; i < current_queue.orders.Count; i++)
                {
                    int show_time = current_queue.orders[i].clip_size;

                    if (current_queue.orders[i].display_time < show_time)
                    {
                        current_queue.orders.Remove(current_queue.orders[i]);
                        continue;
                    }

                    statistic[current_queue.orders[i].name] += show_time;

                    current_queue.orders[i].display_time -= show_time;
                    current_queue.orders[i].result.AddToOrderResult(name, current_time);

                
                    current_time += show_time;
                    current_time = current_time >= 2400 ? current_time - 2400 : current_time;

                }
            }

            return true;
        }
    }
}
