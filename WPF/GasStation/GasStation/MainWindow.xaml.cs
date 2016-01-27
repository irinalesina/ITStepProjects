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

namespace GasStation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            WindowPetrol windowPetrol = new WindowPetrol(this);
            windowPetrol.ShowDialog();
        }

        public void AddValueInReciept(string petrolType, string count, string coast)
        {
           // treeViewReciept.Items.Add(petrolType + "__" + count + "__" + coast);
        }

        private void buttonSubmit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
