using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace CopyFileData
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static string src, dest;
        static double progressCopyProc = 0;
        static object monitor = new object();

        Thread threadCopy;
        Thread threadRunProgress;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonSource_Click(object sender, RoutedEventArgs e)
        {
            textBoxSource.Text = this.GetFilePath();
        }

        private string GetFilePath()
        {
            OpenFileDialog checkFile = new OpenFileDialog();
            checkFile.InitialDirectory = @"D:\ITStepProjects\SystemProgramming\2_day";

            if (checkFile.ShowDialog() == null)
                return "";

            return checkFile.FileName;
        }

        private void buttonDestination_Click(object sender, RoutedEventArgs e)
        {
            textBoxDestination.Text = this.GetFilePath();
        }

        private void buttonStart_Click(object sender, RoutedEventArgs e)
        {
            dest = textBoxDestination.Text;
            src = textBoxSource.Text;

            threadRunProgress = new Thread(RunProgress);
            threadCopy = new Thread(CopyFile);

            threadCopy.Start();
            threadRunProgress.Start();
        }

        void CopyFile()
        {
            Dispatcher.Invoke(new Action(() => buttonStart.IsEnabled = false));
            try
            {

                using (var outputFile = File.Create(dest))
                {
                    using (var inputFile = File.OpenRead(src))
                    {
                        int CopyBufferSize = 100;
                        var buffer = new byte[CopyBufferSize];
                        int bytesRead;
                        long fileSize = inputFile.Length;
                        do
                        {
                            bytesRead = inputFile.Read(buffer, 0, CopyBufferSize);
                            if (bytesRead != 0)
                            {
                                outputFile.Write(buffer, 0, bytesRead);
                            }
                            Thread.Sleep(100);

                            progressCopyProc = (outputFile.Length * 1.0 / fileSize * 100);

                        } while (bytesRead != 0);
                    }
                }
                MessageBox.Show("Copying has completed!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            progressCopyProc = 0;
            Dispatcher.Invoke(new Action(() => buttonStart.IsEnabled = true));
        }

        void RunProgress()
        {
            while(threadCopy.IsAlive)
            {
                Dispatcher.Invoke(new Action(() => progressBarCopyProgress.Value = progressCopyProc));
            }
            
            Dispatcher.Invoke(new Action(() => progressBarCopyProgress.Value = progressCopyProc));
            
        }
    }
}
