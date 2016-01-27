using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    class Shop
    {
        public static SortedDictionary<string, double> products;
        public bool isOpen;

        public Shop()
        {
            isOpen = false;
            products = new SortedDictionary<string, double>() { { "milk", 2.70 }, { "juice", 3.15 },
                { "bread", 1.25 }, { "banana", 0.80 }, { "pork", 5.15 } };
        }

        public void Open()
        {
            if (Opening != null)
            {
                Opening(this, new ShopEventArgs("Shop is opened!"));
            }
            Cashbox cashBox = new Cashbox();
            isOpen = true;
            //cashBox.CteateCheck();
        }
        public event EventHandler<ShopEventArgs> Opening;


        public void Close()
        {
            if (Closing != null)
            {
                Closing(this, new ShopEventArgs("Shop is closed!"));
            }
            isOpen = false;
        }
        public event EventHandler<ShopEventArgs> Closing;
        
    }

    class ShopEventArgs : EventArgs
    {
        public ShopEventArgs(string message)
        {
            Message = message;
        }

        public string Message
        {
            private set;
            get;
        }
    }
}
