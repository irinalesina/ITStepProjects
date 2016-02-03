using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_LINQ
{
    public partial class Form1 : Form
    {

        List<CD> CDs = CD.GetCdsFromXML();
        List<PRODUCER> producers = PRODUCER.GetProducersFromXML();

        public Form1()
        {
            InitializeComponent();

            dataGridViewCDs.DataSource = CDs;
            dataGridViewProducers.DataSource = producers;

        }

        private void artistAfterCCCPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewResult.DataSource = (from cd in CDs where cd.YEAR > 1991 select new { Artist = cd.ARTIST }).ToList();
        }

        private void counrtiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewResult.DataSource = (from cd in CDs group cd by cd.COUNTRY into countries select new { Country = countries.Key }).ToList();
        }

    }
}
