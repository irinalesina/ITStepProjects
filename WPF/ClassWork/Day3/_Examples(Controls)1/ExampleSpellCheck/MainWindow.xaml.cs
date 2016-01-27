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

namespace ExampleSpellCheck
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("ru-Ru"); 
        }

        private void TextBox_SelectionChanged(object sender, RoutedEventArgs e)
        {
            // Если нет выделенного текста, выполняем возврат.
            if (txtSelectText == null)
            {
                return;
            }

            // Иначе считываем выделенный текст.
            txtInfo.Text = String.Format(
                "Выбрано с позиции {0}; количество символов --  {1}",
                txtMainText.SelectionStart,
                txtMainText.SelectionLength);
            txtSelectText.Text = txtMainText.SelectedText;
        }
    }
}
