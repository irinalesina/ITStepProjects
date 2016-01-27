using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Metro
{
    delegate void TransportEvent(uint time);
    class EventQueue
    {
        public SortedDictionary<uint, List<TransportEvent>> event_queue;

        public EventQueue()
        {
            event_queue = new SortedDictionary<uint, List<TransportEvent>>();
        }

        public void Add(uint time, TransportEvent transport_event)
        {
            if(event_queue.ContainsKey(time) == false)
            {
                event_queue[time] = new List<TransportEvent>();
            }

            event_queue[time].Add(transport_event);
        }

        public void Remove(uint time)
        {
            if(event_queue.ContainsKey(time) == true)
            {
                event_queue[time].Clear();
                event_queue.Remove(time);
            }
        }

        public List<TransportEvent> this[uint time]
        {
            get 
            {
                if(event_queue.ContainsKey(time) == true)
                {
                    return event_queue[time];
                }
                throw new IndexOutOfRangeException("In EventQueue.this[time]: index_ is out of range.");
            }
        }

        public bool ContainsKey(uint time)
        {
            return event_queue.ContainsKey(time);
        }


        public void Start(uint work_time, uint period)
        {
            for (uint i = 0; i < work_time; i++)
            {
                var en = event_queue.GetEnumerator();
                en.MoveNext();
                var time = en.Current.Key;
                foreach (var transport_event in en.Current.Value)
                {
                    transport_event(time); //call delegate void TransportEvent(uint time);
                }
                this.Remove(time);
                if (i % period == 0)
                {
                    MetroInfo.Serialize("../../MetroInfo/info.htm");
                    //Console.WriteLine("Sleep");
                    System.Threading.Thread.Sleep(250);
                    //Console.WriteLine("Start");
                }
            }
        }
    }
}
