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

namespace ExampleComboBox
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Subject> Subjects = new List<Subject>()
            {
             new Subject(){Num=1, Name="C#"},
              new Subject(){Num=2, Name="WinForms"},
               new Subject(){Num=3, Name="WPF"},
                new Subject(){Num=4, Name="ADO.NET"},
                 new Subject(){Num=5, Name="ASP.NET"},
            };


            cbSubjects.ItemsSource = Subjects;
            cbSubjects.DisplayMemberPath = "Name";

        }

        private void cbSubjects_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(cbSubjects.SelectedItem!=null)
            {  Subject selSub=(Subject) cbSubjects.SelectedItem;
            lbInfoSel.Content = selSub.Name;
            }
        }
    }

    class Subject
    {
        public int Num { get; set; }

        public string Name { get; set; }
    }
}
