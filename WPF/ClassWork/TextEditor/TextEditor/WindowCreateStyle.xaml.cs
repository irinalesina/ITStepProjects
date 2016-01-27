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

namespace TextEditor
{
    /// <summary>
    /// Interaction logic for WindowCreateStyle.xaml
    /// </summary>
    public partial class WindowCreateStyle : Window
    {

        public WindowCreateStyle()
        {
            InitializeComponent();
        }

        private void buttonCreateStyle_Click(object sender, RoutedEventArgs e)
        {
            // add a check
            // here
            int i;
            if (String.IsNullOrEmpty(textBoxStyleName.Text))
            {
                MessageBox.Show("You're not entering style name!", "Error", MessageBoxButton.OK);
            } 
            else if (comboBoxFontFamily.SelectedItem == null) 
            {
                MessageBox.Show("You're not entering font family!", "Error", MessageBoxButton.OK);
            }
            else if (!(int.TryParse(textBoxFontSize.Text, out i))) 
            {
                MessageBox.Show("You're entering invalid size!", "Error", MessageBoxButton.OK);
            }
            else
            {
                Style style = new Style(typeof(Control));
                style.Setters.Add(new Setter(Control.FontFamilyProperty, comboBoxFontFamily.SelectedItem));
                style.Setters.Add(new Setter(Control.FontSizeProperty, Convert.ToDouble(textBoxFontSize.Text)));
                style.Setters.Add(new Setter(Control.ForegroundProperty, new SolidColorBrush((Color)colorPickerTextForeground.SelectedColor)));
                style.Setters.Add(new Setter(Control.BackgroundProperty, new SolidColorBrush((Color)colorPickerTextBackground.SelectedColor)));

                MainWindow.styles.Add(textBoxStyleName.Text, style);


                MessageBox.Show("New style was created", "INFO", MessageBoxButton.OK);
                this.Close();
            }
        }
    }
}