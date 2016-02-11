using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_CodeFirst_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Context db = new Context(ConfigurationManager.ConnectionStrings["ConnectionStringCarsList"].ConnectionString);

            //Car car = new Car() { Name = "BMW", Fuel = 50, CarInfo = new CarInfo() { Color="Blue" } };

            //db.Cars.Add(car);

            //db.SaveChanges();
          
            foreach(var c in db.Cars)
            {
                Console.WriteLine("{0} {1}: {2}", c.CarInfo.Color, c.Name, c.Fuel);
            }

            
            Console.ReadKey();
        }
    }
}
