using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Junctions
{
    public class Car
    {
        private static Random rand = new Random(DateTime.Now.Ticks.GetHashCode());

        public Junction from, to;
        public Road currentRoad;
        public double speed;
        public double departureTime, arrivalTime;

        public Car()
        {
            to = Form1.junctions[rand.Next(Form1.junctions.Count)];
            this.makeDecision();
        }

        public void makeDecision()
        {
            // съехали со старой дороги
            if (currentRoad != null)
            {
                currentRoad.relatedCars.Remove(this);
            }

            // заехали на новую дорогу
            if (currentRoad == null)
            {
                var sortedRoads = to.relatedRoads.OrderBy(road => road.azimuth).ToList<Road>();

                var randNumber = rand.Next(1, 11);

                if (randNumber <= 7 || sortedRoads.Count == 1)
                {
                    currentRoad = sortedRoads[0];
                }
                else
                {
                    currentRoad = sortedRoads[rand.Next(1, sortedRoads.Count)];
                }
            }
            else
            {
                var sortedRoads = to.relatedRoads.OrderBy(road => Math.Abs(currentRoad.azimuth - road.azimuth)).ToList<Road>();

                var randNumber = rand.Next(1, 11);

                if (randNumber <= 7 || sortedRoads.Count == 1)
                {
                    currentRoad = sortedRoads[0];
                }
                else
                {
                    currentRoad = sortedRoads[rand.Next(1, sortedRoads.Count)];
                }
            }

            currentRoad.relatedCars.Add(this);

            var newJunction = currentRoad.junc1 == to ? currentRoad.junc2 : currentRoad.junc1;
            from = to;
            to = newJunction;

            // расчет длины и времени 
            speed = currentRoad.maxSpeed * Math.Pow(2, -1 * currentRoad.relatedCars.Count / currentRoad.halfLoad);
            departureTime = Form1.CurrentTime;
            arrivalTime = Form1.CurrentTime + currentRoad.Length / speed;
        }
    }
}
