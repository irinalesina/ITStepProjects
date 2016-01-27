using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Forex
{
    class Auditor
    {
        Random random;
        int p_error;

        public Auditor()
        {
            random = new Random();
            p_error = random.Next(1, 15);
        }

        public bool CheckDeal(Deal deal)
        {
            bool result = deal.is_fair;
            if(random.Next(100) < p_error)
            {
                result = !result;
            }
            return result;
        }
    }
}
