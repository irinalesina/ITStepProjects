using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_TransportSystem
{
    public class DbTransportSystem : DbContext
    {
        //"prop" + double click tab - to add property
        public DbSet<Station> Stations { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<RouteInfo> RoutesInfo { get; set; }
        public DbSet<Transport> Transports { get; set; }
        public DbSet<TransportType> TransportTypes { get; set; }
        public DbSet<Schedule> Schedules { get; set; }

        public DbTransportSystem() { }

        public DbTransportSystem(string connectionString) : base(connectionString) { }

    }
}
