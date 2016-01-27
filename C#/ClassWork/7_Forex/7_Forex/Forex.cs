using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Forex
{
    class Forex
    {
        Log log;
        Auditor auditor;


        public void PerformDeal(Deal deal)
        {
            bool auditor_apinion =  auditor.CheckDeal(deal);
        }
    }
}
