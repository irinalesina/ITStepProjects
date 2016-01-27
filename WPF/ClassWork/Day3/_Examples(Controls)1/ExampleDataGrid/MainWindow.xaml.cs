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

namespace ExampleDataGrid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Car> Cars;
        public MainWindow()
        {
            InitializeComponent();
            Cars = new List<Car>()
            {
                new Car{Num=1, Name="BMW X5",  Price=25000},
                new Car{Num=2, Name="BMW X6",  Price=32000},
                new Car{Num=3, Name="Audi A4",  Price=12000},
                new Car{Num=4, Name="Audi A6",  Price=18000},
                new Car{Num=5, Name="Audi A8",  Price=25000},
                new Car{Num=6, Name="Audi Q7",  Price=29000},
                new Car{Num=7, Name="Ford Mondeo",  Price=10000},
            };
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dgMain.ItemsSource = Cars;

            // настройки DateGrid  в коде
            dgMain.ColumnWidth = new DataGridLength(150);      // установка размеров столбцов равным 150
            dgMain.ColumnWidth = DataGridLength.SizeToHeader;  // установка размеров столбцов 
                                                               // в зависимости от ширины заголовка
            dgMain.ColumnWidth = DataGridLength.SizeToCells;   // установка размеров столбцов 
                                                               // в зависимости от ширины данных видимых в данный момент
            dgMain.ColumnWidth = DataGridLength.Auto;          // установка размеров столбцов 
            

        }

        // загрузка строк
        // происходит форматирование строк в зависимости от цены автомобиля!
        private void dgMain_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            if (!(e.Row.DataContext is Car)) return;
            
            Car car = (Car)e.Row.DataContext;

            if (car.Price > 15000)
                e.Row.Foreground = new SolidColorBrush(Colors.Red);
            else
                e.Row.Foreground = new SolidColorBrush(Colors.Blue);
        }
    }

    public class Car
    {
        public int Num { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
