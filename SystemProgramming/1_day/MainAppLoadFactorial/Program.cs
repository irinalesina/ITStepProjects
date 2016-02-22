using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MainAppLoadFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain factorialDomain = AppDomain.CreateDomain("Factorial domain");

            factorialDomain.DomainUnload += FactorialDomainUnLoad;

            string[] argsForFactorial = new string[] { "6" };
            string assemblyPath = factorialDomain.BaseDirectory + "../../../Factorial/bin/Debug/Factorial.exe";
            factorialDomain.ExecuteAssembly(assemblyPath, argsForFactorial);
            
            AppDomain.Unload(factorialDomain);

            Console.ReadKey();
        }

        private static void FactorialDomainUnLoad(object sender, EventArgs e)
        {
            Console.WriteLine("Factorial domain has unloaded!");
        }
    }
}
