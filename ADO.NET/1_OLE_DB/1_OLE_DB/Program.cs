using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_OLE_DB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PatientsInfo:");
            DBConnector.PatientsInfo();

            Console.WriteLine("\nDoctorsCount:");
            DBConnector.DoctorsCount();

            Console.WriteLine("\nPatient - Doctor:");
            DBConnector.PatientDoctor();

            Console.WriteLine("\nDoctorPrice:");
            DBConnector.DoctorPrice();

            Console.WriteLine("\nVisits:");
            DBConnector.Visits();
            

            Console.ReadKey();
        }
    }
}
