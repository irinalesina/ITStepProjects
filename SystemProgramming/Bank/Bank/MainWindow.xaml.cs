using System;
using System.Collections.Generic;
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

namespace Bank
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Thread t1 = new Thread(CreateWindow);
            //t1.Start();
            //Thread t2 = new Thread(CreateWindow);
            //t2.Start();
            //Thread t3 = new Thread(CreateWindow);
            //t3.Start();
            //Thread t4 = new Thread(CreateWindow);
            //t4.Start();
            //Thread t5 = new Thread(CreateWindow);
            //t5.Start();
        }

        private void btnBalance_Click(object sender, RoutedEventArgs e)
        {
            try 
            {
                MessageBox.Show(BankAccount.ShowCash().ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnInput_Click(object sender, RoutedEventArgs e)
        {
            if(String.IsNullOrEmpty(tbInput.Text))
            {
                MessageBox.Show("Enter summ to input!");
            }
            else
            {
                try
                {
                    decimal summ = Convert.ToDecimal(tbInput.Text);
                    BankAccount.InputCash(summ);
                    MessageBox.Show("Cash is inputed!");
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            tbInput.Text = "";
        }

        private void btnOutput_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(tbOutput.Text))
            {
                MessageBox.Show("Enter summ to output!");
            }
            else
            {
                try
                {
                    decimal summ = Convert.ToDecimal(tbOutput.Text);
                    BankAccount.OutputCash(summ);
                    MessageBox.Show("Cash is outputed!");
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            tbOutput.Text = "";
        }

        public static void CreateWindow()
        {
            MVCopy mw = new MVCopy();
        }
    }
}
