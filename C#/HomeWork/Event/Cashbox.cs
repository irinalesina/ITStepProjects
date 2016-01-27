using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    class Cashbox
    {
        private int cash;
        public int Cash
        {
            get
            {
                return cash;
            }
            set
            {
                cash += value;
            }
        }
        List<Check> checks;

        public Cashbox()
        {
            cash = 0;
            checks = new List<Check>();
        }

        public Check CteateCheck()
        {
            Check newCheck = new Check();
            checks.Add(newCheck);
            newCheck.Show();
            return newCheck;
        }
    }
}
