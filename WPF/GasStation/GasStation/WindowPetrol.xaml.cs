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
using System.Windows.Shapes;

namespace GasStation
{
    /// <summary>
    /// Interaction logic for WindowPetrol.xaml
    /// </summary>
    public partial class WindowPetrol : Window
    {
        MainWindow parent;
        public WindowPetrol(MainWindow parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void Window_Closing_1(object sender, System.ComponentModel.CancelEventArgs e)
        {
            parent.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            parent.AddValueInReciept(((ComboBoxItem)comboBoxPetrolType.SelectedItem).Content.ToString(), textBoxCount.Text,
                textBoxCoast.Text);
            this.Close();
        }

        private void textBoxCount_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (comboBoxPetrolType.SelectedItem != null)
            {
                textBoxCoast.Text = (Convert.ToInt32(textBoxCount.Text) *
                    Convert.ToInt32(((ComboBoxItem)comboBoxPetrolType.SelectedItem).Tag)).ToString();
            }
        }

        private void textBoxCoast_TextChanged(object sender, TextChangedEventArgs e)
        {
            //if (comboBoxPetrolType.SelectedItem != null)
            //{
            //    textBoxCoast.Text = (Convert.ToInt32(textBoxCoast.Text) /
            //        Convert.ToInt32(((ComboBoxItem)comboBoxPetrolType.SelectedItem).Tag)).ToString();
            //}
        }

        private void comboBoxPetrolType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (textBoxCount.Text != "")
            {
                if (comboBoxPetrolType.SelectedItem != null)
                {
                    textBoxCoast.Text = (Convert.ToInt32(textBoxCount.Text) *
                        Convert.ToInt32(((ComboBoxItem)comboBoxPetrolType.SelectedItem).Tag)).ToString();
                }
            }
        }
    }
}
