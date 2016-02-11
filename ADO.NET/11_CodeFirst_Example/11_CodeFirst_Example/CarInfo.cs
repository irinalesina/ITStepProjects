using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_CodeFirst_Example
{
    public class CarInfo
    {
        [ForeignKey("Car")]
        public int Id { get; set; }
        public string Color { get; set; }
        public virtual Car Car { get; set; }
    }
}
