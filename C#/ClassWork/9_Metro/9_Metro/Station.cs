using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Metro
{
    class Station : IComparable
    {
        public string name;
        public readonly uint average_period;
        public Queue<Passenger> passengers_queue;
        public readonly uint time_to_next_station;
        public Station next_station;


        public int CompareTo(object st)
        {
            return this.name.CompareTo(((Station)st).name);
        }



        public Station(string station_name, uint time_period, uint _time_to_next_station)
        {
            average_period = time_period;
            passengers_queue = new Queue<Passenger>();
            name = station_name;
            time_to_next_station = _time_to_next_station;
        }

        public void AddNextStation(Station next_station_)
        {
            next_station = next_station_;
        }
        

        public void AddPassengerOnArrival(uint time)
        {
            Passenger passenger = new Passenger(time, this);
            passengers_queue.Enqueue(passenger);
            //Console.WriteLine("({0})", passengers_queue.Count);
            Program.event_queue1.Add(time + average_period, this.AddPassengerOnArrival);
        }

    }
}
