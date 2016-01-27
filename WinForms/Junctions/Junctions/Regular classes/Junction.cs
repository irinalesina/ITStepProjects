using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Junctions
{
    public class Junction
    {
        public int x, y;
        public List<Road> relatedRoads;

        public Junction(int x_, int y_)
        {
            x = x_;
            y = y_;
            relatedRoads = new List<Road>();
        }
    }
}
