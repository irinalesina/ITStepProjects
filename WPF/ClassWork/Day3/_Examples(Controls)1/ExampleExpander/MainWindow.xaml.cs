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

namespace ExampleExpander
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // создание элемента в коде!
            MenuItem newItem = new MenuItem();
            newItem.Header = "Сеть";
            Image image = new Image();
            Uri ImagePath = new Uri(@"Network.png", UriKind.Relative);
            image.Source = new BitmapImage(ImagePath);
            newItem.Icon = image;
            spDemoAdd.Children.Add(newItem);
        }

        private void Expander_Collapsed(object sender, RoutedEventArgs e)
        {
            // событие при сворачивании  Expander
            expTest2.BorderBrush = new SolidColorBrush(Colors.PaleVioletRed);
        }

        private void expTest2_Expanded(object sender, RoutedEventArgs e)
        {
            // событие при разворачивании Expander
            expTest2.BorderBrush = new SolidColorBrush(Colors.SkyBlue);
        }
    }
}
