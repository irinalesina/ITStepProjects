using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Metro
{
    class Transport
    {
        public readonly int seats_count;
        public int occupied_seats;
        public SortedDictionary<Station, List<Passenger>> passengers;
        public Station current_station;
        public uint traveled_distance;
        public string color;

        public Transport(int transport_seats_count, Station start_station)
        {
            seats_count = transport_seats_count;
            occupied_seats = 0;
            passengers = new SortedDictionary<Station, List<Passenger>>();
            current_station = start_station;
            traveled_distance = 0;
        }

        public void TransportComing()
        {
            LeavPassengers();
            TakePassengers();
        }

        private void LeavPassengers()
        {
            if(passengers.ContainsKey(current_station) == true)
            {
                occupied_seats -= passengers[current_station].Count;
                passengers.Remove(current_station);
            }
            
        }

        private void TakePassengers()
        {
            List<Passenger> take_passangers = new List<Passenger>();
            while(occupied_seats != seats_count && current_station.passengers_queue.Count != 0)
            {
                take_passangers.Add(current_station.passengers_queue.Dequeue());
                occupied_seats++;
            }
            passengers.Add(current_station, take_passangers);
        }


        public void RunTransportOnArrival(uint time)
        {
            TransportComing();
            uint time_to_next_station = current_station.time_to_next_station;
            //Console.WriteLine("Transport coming to station {0} time to next st {1}, free seats = {2}",
            //    current_station.name,current_station.time_to_next_station, seats_count - occupied_seats);
            traveled_distance += time;
            if (traveled_distance > Program.distance)
            {
                traveled_distance -= Program.distance;
            }
 
            current_station = current_station.next_station;
            Program.event_queue1.Add(time + time_to_next_station, this.RunTransportOnArrival);
        }
    }
}
