using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Metro
{
    class Program
    {
        public static EventQueue event_queue1 = new EventQueue();
        public static Station[] stations = new Station[5] { new Station("Minsk", 2, 50), new Station("Osipovichi", 15, 150),
            new Station("Bobruisk", 7, 90), new Station("Zhlobin", 12, 120), new Station("Gomel", 4, 35)};
        public static uint distance = 0;
        public static List<Transport> transports = new List<Transport>();
        static void Main(string[] args)
        {
            foreach (var st in stations)
            {
                distance += st.time_to_next_station;
            }

            Random rand = new Random();
            stations[0].AddNextStation(stations[1]);
            stations[1].AddNextStation(stations[2]);
            stations[2].AddNextStation(stations[3]);
            stations[3].AddNextStation(stations[4]);
            stations[4].AddNextStation(stations[0]);


            event_queue1.Add(0, stations[0].AddPassengerOnArrival);
            event_queue1.Add(0, stations[1].AddPassengerOnArrival);
            event_queue1.Add(0, stations[2].AddPassengerOnArrival);
            event_queue1.Add(0, stations[3].AddPassengerOnArrival);
            event_queue1.Add(0, stations[4].AddPassengerOnArrival);

            //Transport transport1 = new Transport(20, stations[0]);
           
            for (int i = 0; i < 5; i++)
            {
                transports.Add(new Transport(20, stations[0]));
            }

            transports[0].color = "#FF0000";//red
            transports[1].color = "#0000FF";//blue
            transports[2].color = "#00FF00";//green
            transports[3].color = "#FFFF00";//yellow
            transports[4].color = "#B2478F";//pink
            
            uint time = 0;
            foreach(var transport in transports)
            {
                event_queue1.Add(time, transport.RunTransportOnArrival);
                time += 30;
            }
                

            event_queue1.Start(1000, 1); //processing EventQueue


            Console.ReadKey();
        }
    }
}
