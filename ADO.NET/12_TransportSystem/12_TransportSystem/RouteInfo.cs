using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_TransportSystem
{
    public class RouteInfo
    {
        [Key]
        public int Id { get; set; }
        
        public Route Route { get; set; }
        
        public Station Station { get; set; }
        public int Order { get; set; }
        public DateTime TimeToNextStation { get; set; }

    }
}
