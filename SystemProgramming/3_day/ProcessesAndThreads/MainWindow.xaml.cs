using System;
using System.Collections.Generic;
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
using System.Diagnostics;
using System.Threading;
using System.Collections.ObjectModel;

namespace ProcessesAndThreads
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Process[] processes = Process.GetProcesses();

        public MainWindow()
        {
            InitializeComponent();
            FillAllProcesses();
            //Thread thteadUpdateProcessesList = new Thread(FillAllProcesses);
            //thteadUpdateProcessesList.Start();
        }

        public void FillAllProcesses()
        {
            //foreach (var proc in Process.GetProcesses())
            //{
            //    ListViewItem item = new ListViewItem();
            //    item.Content = proc.ProcessName;
            //    item.Tag = proc.Id;
            //    lvAllProcesses.Items.Add(item);
            //}
            lvAllProcesses.ItemsSource = (from pc in Process.GetProcesses() select new ListViewItem() { Content = pc.ProcessName, Tag = pc.Id }).ToList();
        }

        private void lvAllProcesses_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                lvAllProcessThreads.Items.Clear();
                var item = (ListViewItem)lvAllProcesses.SelectedItem;
                int procId = (int)item.Tag;
                foreach (var t in Process.GetProcessById(procId).Threads)
                {
                    ListViewItem i = new ListViewItem();
                    ProcessThread th = (ProcessThread)t;
                    i.Content = th.Id;
                    lvAllProcessThreads.Items.Add(i);
                }
 
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
