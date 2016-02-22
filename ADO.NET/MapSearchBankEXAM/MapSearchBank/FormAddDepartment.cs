using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapSearchBank
{
    public partial class FormAddDepartment : Form
    {
        Form parent;
        public FormAddDepartment(Form parent)
        {
            this.parent = parent;
            InitializeComponent();

            this.UpdateBanksList();

            Load += gMapControl1_Load;

            foreach (var c in Program.banksSystem.Сurrency)
                dgVDepCerrency.Rows.Add(new object[] { c.Name });
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            //Настройки для компонента GMap.
            gMapControlAddDepartment.Bearing = 0;

            //CanDragMap - Если параметр установлен в True,
            //пользователь может перетаскивать карту
            ///с помощью правой кнопки мыши.
            gMapControlAddDepartment.CanDragMap = true;

            //Указываем, что перетаскивание карты осуществляется
            //с использованием левой клавишей мыши.
            //По умолчанию - правая.
            gMapControlAddDepartment.DragButton = MouseButtons.Left;

            gMapControlAddDepartment.GrayScaleMode = false;

            //MarkersEnabled - Если параметр установлен в True,
            //любые маркеры, заданные вручную будет показаны.
            //Если нет, они не появятся.
            gMapControlAddDepartment.MarkersEnabled = true;

            //Указываем значение максимального приближения.
            gMapControlAddDepartment.MaxZoom = 18;

            //Указываем значение минимального приближения.
            gMapControlAddDepartment.MinZoom = 2;

            //Устанавливаем центр приближения/удаления
            //курсор мыши.
            gMapControlAddDepartment.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;

            //Отказываемся от негативного режима.
            gMapControlAddDepartment.NegativeMode = false;

            //Разрешаем полигоны.
            gMapControlAddDepartment.PolygonsEnabled = false;

            //Разрешаем маршруты
            gMapControlAddDepartment.RoutesEnabled = false;

            //Скрываем внешнюю сетку карты
            //с заголовками.
            gMapControlAddDepartment.ShowTileGridLines = false;

            //Указываем, что при загрузке карты будет использоваться
            //18ти кратное приближение.
            gMapControlAddDepartment.Zoom = 12;

            //Указываем что все края элемента управления
            //закрепляются у краев содержащего его элемента
            //управления(главной формы), а их размеры изменяются
            //соответствующим образом.
            gMapControlAddDepartment.Dock = DockStyle.Fill;

            //Указываем что будем использовать карты Google.
            gMapControlAddDepartment.MapProvider = GMap.NET.MapProviders.GMapProviders.OpenStreetMap;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;

            //Если вы используете интернет через прокси сервер,
            //указываем свои учетные данные.
            GMap.NET.MapProviders.GMapProvider.WebProxy = System.Net.WebRequest.GetSystemWebProxy();
            GMap.NET.MapProviders.GMapProvider.WebProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;


            //Д
            gMapControlAddDepartment.Position = new GMap.NET.PointLatLng(53.9018722, 27.6574339);
        }

        private void gMapControlAddDepartment_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                return;
            gMapControlAddDepartment.Overlays.Clear();
            double X = gMapControlAddDepartment.FromLocalToLatLng(e.X, e.Y).Lng;
            double Y = gMapControlAddDepartment.FromLocalToLatLng(e.X, e.Y).Lat;

            GMapOverlay markersOverlay = new GMapOverlay("NewMarkers");
            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(Y, X), GMarkerGoogleType.green);
            //marker.ToolTip = new GMapRoundedToolTip(marker);
            //marker.ToolTipText = "Красная площадь";
            markersOverlay.Markers.Add(marker);
            gMapControlAddDepartment.Overlays.Add(markersOverlay);
            //fix ставим на правильное место
            gMapControlAddDepartment.Position = gMapControlAddDepartment.Position;

            textBoxX.Text = X.ToString();
            textBoxY.Text = Y.ToString();
        }

        private void buttonAddBank_Click(object sender, EventArgs e)
        {
            FormAddBank formAddBank = new FormAddBank(this);
            formAddBank.ShowDialog();
        }

        public void UpdateBanksList()
        {
            comboBoxBanks.Items.Clear();
            foreach (var bank in Program.banksSystem.Bank)
                comboBoxBanks.Items.Add(bank.Name);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(this.IsValid())
            {
                Department dep = new Department() {
                    Name = textBoxDepartment.Text, 
                    Bank = (from bank in Program.banksSystem.Bank where bank.Name==comboBoxBanks.SelectedItem.ToString() select bank.Id).ToList()[0], 
                    Phone = (textBoxPhone.Text == "" ? null : textBoxPhone.Text), 
                    Address = (textBoxAddress.Text == "" ? null : textBoxAddress.Text), 
                    Сoordinate_x = (float)Convert.ToDouble(textBoxX.Text),
                    Сoordinate_y = (float)Convert.ToDouble(textBoxY.Text)};
                Program.banksSystem.Department.Add(dep);
                Program.banksSystem.SaveChanges();
                for (int i = 0; i < dgVDepCerrency.RowCount; i++)
                { 
                    var currencyIsFind = dgVDepCerrency[3, i].Value;
                    if(currencyIsFind != null && (bool)currencyIsFind != false) 
                    {
                        DeprtmentsСurrencies depc = new DeprtmentsСurrencies() {
                            Department = dep.Id,
                            Buy = Convert.ToDecimal(dgVDepCerrency[1, i].Value), 
                            Sell = Convert.ToDecimal(dgVDepCerrency[2, i].Value)};
                        var currency = dgVDepCerrency[0, i].Value.ToString();
                        var list = (from c in Program.banksSystem.Сurrency where c.Name == currency select c.Id).ToList();
                        var temp = list[0];
                        depc.Currency = temp;
                        Program.banksSystem.DeprtmentsСurrencies.Add(depc);
                    }
                }
                Program.banksSystem.SaveChanges();
                MessageBox.Show("Department is added!");
                ((Form1)parent).AddAddedDep(dep);
                this.Close();
            }
        }


        private bool IsValid()
        {
            if(comboBoxBanks.SelectedIndex < 0)
            {
                MessageBox.Show("Select bank!");
                return false;
            }
            if(textBoxDepartment.Text == "")
            {
                MessageBox.Show("Enter department name!");
                return false;
            }
            if ((from dep in Program.banksSystem.Department where dep.Name==textBoxDepartment.Text select dep).ToList().Count() > 0)
            {
                MessageBox.Show("Department was find!");
                return false;
            }
            //if (textBoxPhone.Text == "")
            //{
            //    MessageBox.Show("Enter phone!");
            //    return false;
            //}
            //if (textBoxAddress.Text == "")
            //{
            //    MessageBox.Show("Enter address!");
            //    return false;
            //}
            if (textBoxX.Text == "")
            {
                MessageBox.Show("Enter department position on the map!");
                return false;
            }
            return true;
        }


    }
}
