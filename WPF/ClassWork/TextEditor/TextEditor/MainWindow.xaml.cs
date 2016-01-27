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

namespace TextEditor {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Dictionary<string, Style> styles;

        public MainWindow() 
        {
            InitializeComponent();
            styles = new Dictionary<string, Style>();
            comboBoxStyles.ItemsSource = styles;
            comboBoxStyles.DisplayMemberPath = "Key";
            comboBoxStyles.SelectedValuePath = "Value";
            //textBoxEditor.Style = new Style();
        }

        private void buttonCreateStyle_Click(object sender, RoutedEventArgs e)
        {
            WindowCreateStyle windowCreateStyle = new WindowCreateStyle();
          
            windowCreateStyle.ShowDialog();
            comboBoxStyles.ItemsSource = null;
            comboBoxStyles.ItemsSource = styles;
        }

    }
}
