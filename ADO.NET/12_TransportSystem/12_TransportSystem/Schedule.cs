using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_TransportSystem
{
    public class Schedule
    {
        [Key]
        public int Id { get; set; }
      
        public Route Route { get; set; }
       
        public Transport Transport { get; set; }
        public DateTime ArrivalTime { get; set; }
        public string DateType { get; set; } // working/output
    }
}
