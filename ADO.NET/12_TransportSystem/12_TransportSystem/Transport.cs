using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_TransportSystem
{
    public class Transport
    {
        public int Id { get; set; }
     
        public TransportType TransportType { get; set; }
        public ICollection<Schedule> Schedules { get; set; }

    }
}
