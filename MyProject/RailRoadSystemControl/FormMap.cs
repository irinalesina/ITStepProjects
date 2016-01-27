using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainControlSystem
{
    public partial class FormMap : Form
    {
        FormUserMode parent;

        public FormMap(FormUserMode parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void FormMap_Load(object sender, EventArgs e)
        {
            Environment.SetEnvironmentVariable("DOTNETBROWSER_BIN_DIR", @"D:\Library\DotNetBrowser.Chromium");

            // Create Browser instance.
            //DotNetBrowser.Browser browser = DotNetBrowser.Chromium.BrowserFactory.Create();
            //browser.LoadURL("http://www.map.by");
            webBrowserGoogleMaps.Navigate("www.google.com/maps");
        }
    }
}
