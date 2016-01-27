using System;
using System.Windows;

namespace ExampleWindowsEvents
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            listBox.Items.Add("InitializeComponent");
        }

        // Возникает сразу же после первой визуализации окна.
        private void Window_ContentRendered(object sender, EventArgs e)
        {
            listBox.Items.Add("ContentRendered");
        }

        // Происходит когда окно полностью инициализировано и готово к взаимодействию.
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            listBox.Items.Add("Loaded");
        }

        // Возникает, когда пользователь переключается на это окно, а также при первой загрузке окна.
        private void Window_Activated(object sender, EventArgs e)
        {
            listBox.Items.Add("Activated");
        }

        // Возникает, когда пользователь переходит на другое окно, а также когда окно закрывается.
        private void Window_Deactivated(object sender, EventArgs e)
        {
            listBox.Items.Add("Deactivated");
        }

        // Возникает при закрытии окна. Позволяет отменить операцию закрытия.
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы уверены?", "Внимание!", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }

        // Возникает после закрытия окна.
        private void Window_Closed(object sender, EventArgs e)
        {
            MessageBox.Show("Closed");
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            listBox.Items.Add("SizeChanged");
        }

        private void Window_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            listBox.Items.Add("MouseDown");
        }

        private void Window_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            listBox.Items.Add("KeyDown "+ e.Key.ToString());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Вариант 1
            Double width = SystemParameters.FullPrimaryScreenWidth;
            Double height = SystemParameters.FullPrimaryScreenHeight;

            //// Вариант 2 не учитывается панель задач.
            //width = SystemParameters.WorkArea.Width;
            //height = SystemParameters.WorkArea.Height;

            this.Top = (height - this.Height) / 2;
            this.Left = (width - this.Width) / 2;
        }
    }
}


