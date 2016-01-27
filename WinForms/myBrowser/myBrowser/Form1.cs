using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myBrowser
{
    public partial class FormBrowser : Form
    {
        public FormBrowser()
        {
            InitializeComponent();
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBoxAddress.Text);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            textBoxAddress.Text = webBrowser1.Url.ToString();
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
            textBoxAddress.Text = webBrowser1.Url.ToString();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
            textBoxAddress.Text = webBrowser1.Url.ToString();
        }

    }
}
