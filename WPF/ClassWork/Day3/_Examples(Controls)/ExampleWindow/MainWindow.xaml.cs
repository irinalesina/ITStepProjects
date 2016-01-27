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

namespace ExampleWindow
{
    //Демонстрация основных свойств Window
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.AllowsTransparency=false;              // позволяет использовать фон с прозрачностью.
            
            Uri iconUri = new Uri(@"Icons\MainIcon.ico", UriKind.RelativeOrAbsolute); //путь к файлу с иконкой для приложения.
            this.Icon = BitmapFrame.Create(iconUri);   // установка иконки для приложения.   
            
            this.Top=10;
            this.Left = 10;                            //расстояние между углом окна и краями экрана.
            
            ResizeMode = ResizeMode.CanResize;         //перечисление, указывающее на возможность изменять размеры окна.
            //ResizeMode.CanResize;          //размер окна можно изменять
            //ResizeMode.CanMinimize;        //окно можно только свернуть/развернуть
            //ResizeMode.CanResizeWithGrip;  // размер окна можно изменять + отображается захват
            //ResizeMode.NoResize;           // размер окна не изменяется
                      
            this.ShowInTaskbar=true;    //указывает на то будет ли окно видимо в панели задач.
            
            //окно увеличивается по мере увеличения размеров контента.
            this.SizeToContent=SizeToContent.Manual; 
            // SizeToContent.Height; // окно автоматически установит свою высоту в соответствии с высотой (но не шириной) содержимого.
            // SizeToContent.Width;          // окно автоматически установит свою ширину в соответствии с шириной (но не высотой) содержимого.
            // SizeToContent.Manual;         // размер окна не будет изменятся автоматически по содержимому
            // SizeToContent.WidthAndHeight; // окно автоматически установит свою ширину и высоту в соответствии с шириной и высотой содержимого.

            
            this.Topmost=true;         // отображаться поверх остальных окон.
            this.WindowStartupLocation=WindowStartupLocation.CenterScreen;  //позиция, в которой окно будет отображено.
            this.WindowState=WindowState.Normal; //состояние окна: свернуто, развернуто или обычное состояние.
            this.WindowStyle = WindowStyle.SingleBorderWindow; //-стиль рамки окна.



        }
    }
}
