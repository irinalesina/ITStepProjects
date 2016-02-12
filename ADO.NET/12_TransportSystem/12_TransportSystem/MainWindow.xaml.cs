using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _12_TransportSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DbTransportSystem dbTransportSystem = new DbTransportSystem(ConfigurationManager.ConnectionStrings["ConnectionStringTransportSystem"].ConnectionString);
            Station station = new Station() { Name = "Вокзал" };// +
            Route route = new Route() { Name = "Вокзал - Веснянка" };// +
            RouteInfo routeInfo = new RouteInfo();// +
            routeInfo.Route = route;
            routeInfo.Station = station;
            Schedule sx = new Schedule() { Route = route, Transport = new Transport() { TransportType=} };

            //TransportType trType = new TransportType() { Name = "bus" };// +
            //Transport transport = new Transport() { TransportType = trType };// +


            //trType.Transports.Add(transport);


            //Schedule schedule = new Schedule() { Route = route, Transport = transport, DateType = "woring" };// +


            //transport.Schedules.Add(schedule);
            //route.Schedules.Add(schedule);

            //dbTransportSystem.Stations.Add(station);
            //dbTransportSystem.Routes.Add(route);
            dbTransportSystem.RoutesInfo.Add(routeInfo);
            //dbTransportSystem.Schedules.Add(schedule);
            //dbTransportSystem.Transports.Add(transport);
            //dbTransportSystem.TransportTypes.Add(trType);


            dbTransportSystem.SaveChanges();

            InitializeComponent();
        }
    }
}
