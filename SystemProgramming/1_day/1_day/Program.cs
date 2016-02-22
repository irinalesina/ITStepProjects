using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _1_day
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain secondaryDomain = AppDomain.CreateDomain("Secondary domain");

            secondaryDomain.AssemblyLoad += DomainAssemblyLoad;
            secondaryDomain.DomainUnload += DomainAssemblyUnLoad;

            Console.WriteLine("Domen: {0}", secondaryDomain.FriendlyName);
            secondaryDomain.Load(new AssemblyName("System.Data"));
            Assembly[] assemblies = secondaryDomain.GetAssemblies();

            foreach(var assembly in assemblies)
            {
                Console.WriteLine(assembly.GetName().Name);
            }
            AppDomain.Unload(secondaryDomain);

            Console.ReadKey();
        }

        private static void DomainAssemblyLoad(object sender, AssemblyLoadEventArgs e)
        {
            Console.WriteLine("Load");
        }

        private static void DomainAssemblyUnLoad(object sender, EventArgs e)
        {
            Console.WriteLine("UnLoad");
        }
    }
}
