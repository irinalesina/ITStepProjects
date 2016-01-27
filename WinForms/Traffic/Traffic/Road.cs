using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traffic
{
    class Road
    {
        public CrossRoad cr1, cr2;
 
        public Road(CrossRoad cr1, CrossRoad cr2)
        {
            this.cr1 = cr1;
            this.cr2 = cr2;
        }
    }
}
