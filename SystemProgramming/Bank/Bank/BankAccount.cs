using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class BankAccount
    {
        private static decimal cash = 1000;

        // methods
        public static decimal ShowCash()
        {
            return cash;
        }

        public static void InputCash(decimal summ)
        {
            if (summ < 0)
                throw new OutOfMemoryException("Invalid summ!");
            checked
            {
                cash += summ;
            }
        }

        public static void OutputCash(decimal summ)
        {
            if (summ < 0)
                throw new OutOfMemoryException("Invalid summ!");
            if (summ > cash)
                throw new OutOfMemoryException("Not enough cash!");
            cash -= summ;
        }
    }
}
