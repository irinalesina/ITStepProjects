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

namespace ExampleImage
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Относительный путь к картинке
            image1.Source = new BitmapImage(new Uri(@"\Images\index.jpg", UriKind.Relative));
            // Абсолютный путь к картинке
            image2.Source = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + "\\Pic\\index.jpg", UriKind.Absolute));
 
        }
    }
}
