using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapSearchBank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            Load += gMapControl1_Load;
        }



        private void gMapControl1_Load(object sender, EventArgs e)
        {
            //Настройки для компонента GMap.
            gMapControl1.Bearing = 0;

            //CanDragMap - Если параметр установлен в True,
            //пользователь может перетаскивать карту
            ///с помощью правой кнопки мыши.
            gMapControl1.CanDragMap = true;

            //Указываем, что перетаскивание карты осуществляется
            //с использованием левой клавишей мыши.
            //По умолчанию - правая.
            gMapControl1.DragButton = MouseButtons.Left;

            gMapControl1.GrayScaleMode = false;

            //MarkersEnabled - Если параметр установлен в True,
            //любые маркеры, заданные вручную будет показаны.
            //Если нет, они не появятся.
            gMapControl1.MarkersEnabled = true;

            //Указываем значение максимального приближения.
            gMapControl1.MaxZoom = 18;

            //Указываем значение минимального приближения.
            gMapControl1.MinZoom = 2;

            //Устанавливаем центр приближения/удаления
            //курсор мыши.
            gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;

            //Отказываемся от негативного режима.
            gMapControl1.NegativeMode = false;

            //Разрешаем полигоны.
            gMapControl1.PolygonsEnabled = false;

            //Разрешаем маршруты
            gMapControl1.RoutesEnabled = false;

            //Скрываем внешнюю сетку карты
            //с заголовками.
            gMapControl1.ShowTileGridLines = false;

            //Указываем, что при загрузке карты будет использоваться
            //18ти кратное приближение.
            gMapControl1.Zoom = 12;

            //Указываем что все края элемента управления
            //закрепляются у краев содержащего его элемента
            //управления(главной формы), а их размеры изменяются
            //соответствующим образом.
            gMapControl1.Dock = DockStyle.Fill;

            //Указываем что будем использовать карты Google.
            gMapControl1.MapProvider = GMap.NET.MapProviders.GMapProviders.OpenStreetMap;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;

            //Если вы используете интернет через прокси сервер,
            //указываем свои учетные данные.
            GMap.NET.MapProviders.GMapProvider.WebProxy = System.Net.WebRequest.GetSystemWebProxy();
            GMap.NET.MapProviders.GMapProvider.WebProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;


            //Д
            gMapControl1.Position = new GMap.NET.PointLatLng(53.9018722, 27.6574339);
        }



        private void buttonAddDepartment_Click(object sender, EventArgs e)
        {
            FormAddDepartment formAddDepartment = new FormAddDepartment(this);
            formAddDepartment.ShowDialog();
        }

        private void buttonShowAllDepartments_Click(object sender, EventArgs e)
        {
            gMapControl1.Overlays.Clear();
            foreach (var c in Program.banksSystem.Department)
            {
                //Создание маркера
                GMapOverlay markersOverlay = new GMapOverlay(c.Bank1.Id.ToString());
                GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(c.Сoordinate_y, c.Сoordinate_x), GMarkerGoogleType.green);
                //Добавляем описание
                marker.ToolTip = new GMapRoundedToolTip(marker);
                marker.ToolTipText = c.Bank1.Name + "\n" + c.Name + "\n" + c.Address + "\n" + c.Phone + "\n";
                var departmentCurrencies = (from depCurr in Program.banksSystem.DeprtmentsСurrencies
                                            join curr in Program.banksSystem.Сurrency on depCurr.Сurrency equals curr
                                            where depCurr.Department == c.Id
                                            select new
                                                {
                                                    Currency = curr.Name,
                                                    Buy = depCurr.Buy,
                                                    Sell = depCurr.Sell
                                                }).ToList();
                foreach (var cur in departmentCurrencies)
                {
                    marker.ToolTipText += cur.Currency + "  " + cur.Buy + "  " + cur.Sell + "\n";
                }
                //Добавляем на карту
                markersOverlay.Markers.Add(marker);
                gMapControl1.Overlays.Add(markersOverlay);
                //fix ставим на правильное место
                gMapControl1.Position = gMapControl1.Position;
            }
        }

        public void AddAddedDep(Department c)
        {
            GMapOverlay markersOverlay = new GMapOverlay(c.Bank1.Id.ToString());
            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(c.Сoordinate_y, c.Сoordinate_x), GMarkerGoogleType.green);
            //Добавляем описание
            marker.ToolTip = new GMapRoundedToolTip(marker);
            marker.ToolTipText = c.Bank1.Name + "\n" + c.Name + "\n" + c.Address + "\n" + c.Phone + "\n";
            var departmentCurrencies = (from depCurr in Program.banksSystem.DeprtmentsСurrencies
                                        join curr in Program.banksSystem.Сurrency on depCurr.Сurrency equals curr
                                        where depCurr.Department == c.Id
                                        select new
                                        {
                                            Currency = curr.Name,
                                            Buy = depCurr.Buy,
                                            Sell = depCurr.Sell
                                        }).ToList();
            foreach (var cur in departmentCurrencies)
            {
                marker.ToolTipText += cur.Currency + "  " + cur.Buy + "  " + cur.Sell + "\n";
            }
            //Добавляем на карту
            markersOverlay.Markers.Add(marker);
            gMapControl1.Overlays.Add(markersOverlay);
            //fix ставим на правильное место
            gMapControl1.Position = gMapControl1.Position;
        }

    }


}
