using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Threading;

namespace TaskManager {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window 
    {
        public ProcessManager processManager { get; set; }
        public DispatcherTimer timerUpdateProcesses = new DispatcherTimer();

        public MainWindow() 
        {
            InitializeComponent();
            
            processManager = new ProcessManager();
            dataGridAllProcesses.ItemsSource = processManager.Processes;
            //dataGridAllProcesses.SelectedItem = processManager.CurrentProcess;


            timerUpdateProcesses.Tick += timerUpdateProcesses_Tick;
            timerUpdateProcesses.Interval = new TimeSpan(0,0,1);
            timerUpdateProcesses.Start();
        }

        private void timerUpdateProcesses_Tick(object sender, EventArgs e) 
        {
            //timerUpdateProcesses.Stop();
            //UpdateDataGridAllProcesses();
            //timerUpdateProcesses.Start();

            processManager.UpdateProcesses();
        }

        private void buttonKillProcess_Click(object sender, RoutedEventArgs e)
        {
            try 
            {
                //timerUpdateProcesses.Stop();
                var answer = MessageBox.Show("Are you sure?", "Kill process", MessageBoxButton.YesNo);

                if (answer == MessageBoxResult.Yes) {
                    var selectedProcess = dataGridAllProcesses.SelectedItem as Process;
                    
                    processManager.Processes.Remove(selectedProcess);
                    selectedProcess.Kill();
                }
                //timerUpdateProcesses.Start();
            } 
            catch 
            {
                MessageBox.Show("Access denied", "Info", MessageBoxButton.OK);
            }
            
        }

        //public void UpdateDataGridAllProcesses() 
        //{
        //    processManager.UpdateProcesses();
        //    dataGridAllProcesses.ItemsSource = processManager.Processes;
        //}

        private void buttonFindProcess_Click(object sender, RoutedEventArgs e) 
        {
            timerUpdateProcesses.Stop();
            if(textBoxFindProcess.Text != "") 
            {
                dataGridAllProcesses.ItemsSource = processManager.FindProcessesByName(textBoxFindProcess.Text);
            }
            
        }

        private void textBoxFindProcess_TextChanged(object sender, TextChangedEventArgs e) {
            if (textBoxFindProcess.Text == "")
            {
                //this.UpdateDataGridAllProcesses();
                processManager.UpdateProcesses();
                timerUpdateProcesses.Start();
            }
        }


    }  

}
