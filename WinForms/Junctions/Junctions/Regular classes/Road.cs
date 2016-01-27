using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Junctions
{
    public class Roads : List<Road>
    {
        public Roads()
            : base()
        {
        }

        public void Add(Junction junc1_, Junction junc2_, int maxSpeed_, int halfLoad_)
        {
            var DirectRoad = new Road(junc1_, junc2_, maxSpeed_, halfLoad_);
            var ReverseRoad = new Road(junc2_, junc1_, maxSpeed_, halfLoad_);
            this.Add(DirectRoad);
            this.Add(ReverseRoad);
        }
    }

    public class Road
    {
        public Junction junc1, junc2;
        public List<Car> relatedCars;
        public int maxSpeed;
        public int halfLoad;
        public double azimuth;
        public double Length
        {
            get
            {
                return Math.Sqrt(Math.Pow(junc2.x - junc1.x, 2) + Math.Pow(junc2.y - junc1.y, 2));
            }
        }

        public Road(Junction junc1_, Junction junc2_, int maxSpeed_, int halfLoad_)
        {
            if (junc1_.relatedRoads.Count == 4)
            {
                throw new ArgumentException("In Road(Junction. Junction): one of junctions already has 4 roads!");
            }

            relatedCars = new List<Car>();
            junc1 = junc1_;
            junc1_.relatedRoads.Add(this);
            junc2 = junc2_;
            maxSpeed = maxSpeed_;
            halfLoad = halfLoad_;
            azimuth = Math.Atan2((double)(junc2.x - junc1.x), (double)(junc2.y - junc1.y));
        }
    }
}
