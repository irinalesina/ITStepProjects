using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Forex
{
    class Player
    {
        Random random;
        int unfair;
        int deal_size;

        public Player()
        {
            random = new Random();
            unfair = random.Next(3) * random.Next(3) * random.Next(3);
            deal_size = (int)Math.Pow(10, random.Next(8));
        }

        public Deal MakeDeal()
        {
            // change this
            // fair
            return new Deal(this, random.Next(deal_size / 2, deal_size / 2 * 3), random.Next(100) > unfair);
        }
    }
}
