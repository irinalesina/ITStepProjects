using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Metro
{
    class Passenger
    {
        public Station from, to;
        public Passenger(uint time, Station station_from)
        {
            from = station_from;

            Random rand = new Random();
            int current_station = Array.FindIndex(Program.stations, (st) => st == station_from);
            int stations_count = Program.stations.Length;
            to = Program.stations[rand.Next(current_station + 1, stations_count - 1 + current_station) % stations_count];

            //Console.Write("Pasr comes at {0} to station {1}", time, from.name);
        }
    }
}
