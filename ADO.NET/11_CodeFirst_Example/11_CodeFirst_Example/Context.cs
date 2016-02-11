using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_CodeFirst_Example
{
    public class Context : DbContext
    {
        //"prop" + double click tab - to add property
        public DbSet<Car> Cars { get; set; }

        public Context() { }

        public Context(string connectionString) : base(connectionString) { }

    }
}
