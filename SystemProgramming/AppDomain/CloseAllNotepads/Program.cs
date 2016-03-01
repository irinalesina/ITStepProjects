using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloseAllNotepads
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var process in Process.GetProcessesByName("notepad"))
            {
                Console.WriteLine("Kill notepad: {0} - {1}", process.ProcessName, process.Id);
                process.Kill();
            }
        }
    }
}
