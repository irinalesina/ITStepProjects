using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomain_
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain runNotepads = AppDomain.CreateDomain("Start run notepads");
            AppDomain killNotepads = AppDomain.CreateDomain("Kill all notepads");

            //string assemblyPathRunNotepads = "C:\\Windows\\System32\\calc.exe";
            string assemblyPathRunNotepads = "../../../RunNotepads/bin/Debug/RunNotepads.exe";
            string assemblyPathKillNotepads = "../../../CloseAllNotepads/bin/Debug/CloseAllNotepads.exe";

            runNotepads.ExecuteAssembly(assemblyPathRunNotepads);
            killNotepads.ExecuteAssembly(assemblyPathKillNotepads);

            AppDomain.Unload(runNotepads);
            AppDomain.Unload(killNotepads);
            Console.WriteLine("End");

            Console.ReadKey();
        }
    }
}
