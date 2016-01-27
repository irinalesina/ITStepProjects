using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Collections;

namespace TaskManager
{
    public class ProcessManager : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ProcessManager()
        {
            processes = new ObservableCollection<Process>(Process.GetProcesses());
            CurrentProcess = Process.GetCurrentProcess();
        }

        private ObservableCollection<Process> processes;
        public ObservableCollection<Process> Processes
        {
            get
            {
                return processes;
            }
            set
            {
                processes = value;
                OnPropertyChanged("Processes");
            }
        }

        private Process currentProcess;
        public Process CurrentProcess
        {
            get
            {
                return currentProcess;
            }
            set
            {
                currentProcess = value;
                OnPropertyChanged("CurrentProcess");
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
            var ev = PropertyChanged;
            if (ev != null)
                ev(this, new PropertyChangedEventArgs(propertyName));
        }

        public void UpdateProcesses()
        {
            List<Process> currentProcesses = Process.GetProcesses().ToList();
            var compareProc = new CompareProcessById();

            List<Process> processesToDelete = processes.Except(currentProcesses, compareProc).ToList();
            foreach (var processToDel in processesToDelete)
            {
                processes.Remove(processes.First(proc => proc.Id == processToDel.Id));
            }

            List<Process> processeToAdd = currentProcesses.Except(processes, compareProc).ToList();
            foreach (var process in processeToAdd) 
            {
                processes.Add(process);
            }
        }

        public ObservableCollection<Process> FindProcessesByName(string processName)
        {
            processes = new ObservableCollection<Process>(processes.Where(process => process.ProcessName == processName));
            return processes;
        }
    }


    public class CompareProcessById : IEqualityComparer<Process> 
    {
        public bool Equals(Process x, Process y)
        {
            return x.Id == y.Id;
        }

        public int GetHashCode(Process obj)
        {
            return obj.Id;
        }
    }

}
