using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_AsincMode
{
    class Order
    {
        public string OrderDate { get; set; }
        public string ShippedDate { get; set; }
        public string Freight { get; set; }
        public string ShipCity { get; set; }
        public string ShipCountry { get; set; }
        public string ShipRegion { get; set; }
        public OrderInfo orderInfo { get; set; }
        public Customer customer { get; set; }
    }
}
