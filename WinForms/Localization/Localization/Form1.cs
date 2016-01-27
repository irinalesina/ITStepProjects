using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Localization
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLocalization_Click(object sender, EventArgs e)
        {
            var culture = buttonLocalization.Text;
            CultureInfo myCultureInfo = new CultureInfo(culture);

            
            
            if(culture == "en-US")
            {
                buttonLocalization.Text = "ru-RU";
                //return CommonResource.ResourceManager.GetString(buttonHome, new System.Globalization.CultureInfo(culture));
            }
            else
            {
                buttonLocalization.Text = "en-US";
            }

            
            Thread.CurrentThread.CurrentCulture = myCultureInfo;
            Thread.CurrentThread.CurrentUICulture = myCultureInfo;

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));


            buttonHome.Text = resources.GetString("buttonHome.Text", myCultureInfo);


        }
    }
}
