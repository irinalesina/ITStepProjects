using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RunNotepads
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 5; i++)
            {
                Process runNotepad = new Process();
                runNotepad.StartInfo.FileName = "notepad";
                //runNotepad.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                runNotepad.Start();
                Console.WriteLine("Start notepad: {0} - {1}", runNotepad.ProcessName, runNotepad.Id);
            }

        }
    }
}
