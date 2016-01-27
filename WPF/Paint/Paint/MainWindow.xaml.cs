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

namespace Paint
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double xShape = 0, yShape = 0;
        object clickedElenemt = null;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void comboBoxElements_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(comboBoxElements.SelectedItem.ToString() == "ellipse")
            {
                Ellipse ellipse = new Ellipse() 
                { 
                    HorizontalAlignment = HorizontalAlignment.Center,
                    VerticalAlignment = VerticalAlignment.Center, Width = 100, Height = 100,
                    Stroke = System.Windows.Media.Brushes.Black ,
                    Fill = System.Windows.Media.Brushes.Aqua
                };
                ellipse.MouseDown += ShapeMouseDown;
                mainGrid.Children.Add(ellipse);
            }
            else if(comboBoxElements.SelectedItem.ToString() == "square")
            {
                Rectangle rect = new Rectangle()
                {
                    HorizontalAlignment = HorizontalAlignment.Center,
                    VerticalAlignment = VerticalAlignment.Center,
                    Width = 100,
                    Height = 100,
                    Stroke = System.Windows.Media.Brushes.Black
                };
                rect.MouseDown += ShapeMouseDown;
                mainGrid.Children.Add(rect);
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            comboBoxElements.Items.Add("ellipse");
            comboBoxElements.Items.Add("square");
        }

        private void ShapeMouseDown(object sender, MouseEventArgs e)
        {
            var pos = Mouse.GetPosition(this);
            xShape = pos.X;
            yShape = pos.Y;
            clickedElenemt = e.Source;
        }



        private void mainWimdow_MouseUp(object sender, MouseButtonEventArgs e)
        {
            var pos = Mouse.GetPosition(this);
            double xShift = pos.X - xShape;
            double yShift = pos.Y - yShape;
            if (clickedElenemt != null && clickedElenemt as Ellipse != null)
            {
                Thickness margin = ((Ellipse)e.Source).Margin;
                margin.Left += xShift;
                margin.Top += yShift;
                ((Ellipse)e.Source).Margin = margin;

            }
            xShape = 0;
            yShape = 0;
            clickedElenemt = null;
        }

    }
}
