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
        //1
        private void artistAfterCCCPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //LINQ
            //dataGridViewResult.DataSource = (from cd in CDs where cd.YEAR > 1991 select new { Artist = cd.ARTIST, Year = cd.YEAR }).ToList();

            //extention method
            dataGridViewResult.DataSource = CDs.Where(x => x.YEAR > 1991).Select(y => new { Artist = y.ARTIST, Year = y.YEAR }).ToList();
        }
        //2
        private void counrtiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //LINQ
            //dataGridViewResult.DataSource = (from cd in CDs group cd by cd.COUNTRY into countries select new { Country = countries.Key }).ToList();

            //extention method
            dataGridViewResult.DataSource = CDs.GroupBy(c => c.COUNTRY).Select(x => new { Country = x.Key }).ToList();
        }
        //3
        private void aldomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewResult.DataSource = (from cd in CDs where cd.COUNTRY == "USA" orderby cd.YEAR ascending select new { Title = cd.TITLE, Year = cd.YEAR }).ToList();
        }
        //4
        private void titlesPriceForCountryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewResult.DataSource = (from cd in CDs group cd by cd.COUNTRY into cd_gr select new { Country = cd_gr.Key, PriceSum = cd_gr.Sum(c=>c.PRICE) }).ToList();
        }
        //5
        private void companyTitleCountGroupByYearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewResult.DataSource = (from cd in CDs
                                             group cd by new { cd.COMPANY, cd.YEAR } into comp_year_gr orderby comp_year_gr.Key.YEAR
                                             select
                                                 new { Company = comp_year_gr.Key.COMPANY, Count = comp_year_gr.Count(), Year = comp_year_gr.Key.YEAR }).ToList();
        }
        //6
        private void producerAndTitleWithMaxFeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewResult.DataSource = (from prod in producers
                                             join cd in CDs on prod.ID equals cd.PRODUCER where prod.FEE==(from p in producers select p.FEE).Max()
                                             select new { Producer = prod.NAME, Title = cd.TITLE }).ToList();
        }
        //7
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            dataGridViewResult.DataSource = (from prod in producers
                                             join cd in CDs on prod.ID equals cd.PRODUCER
                                             where cd.YEAR > 1987 && cd.YEAR < 1991
                                             group prod by prod.NAME into gr
                                             select new { Producer = gr.Key, TitleCount = gr.Count() }).ToList();
        }
        //8
        private void producerGotFeeLastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewResult.DataSource = (from prod in producers
                                             where prod.DATE == (from p in producers select p.DATE).Max()
                                             select new { Producer = prod.NAME, Date = prod.DATE }).ToList();
        }
        //9
        private void titleWithMinPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewResult.DataSource = (from prod in producers
                                             join cd in CDs on prod.ID equals cd.PRODUCER
                                             where cd.PRICE == (from c in CDs select c.PRICE).Min()
                                             select new { Title = cd.TITLE, Artist = cd.ARTIST, Producer = prod.NAME }).ToList();
        }
        //10
        private void allInfoAboutTitlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //LINQ
            //dataGridViewResult.DataSource = (from cd in CDs orderby cd.YEAR, cd.PRICE, cd.TITLE ascending select cd).ToList();
            //dataGridViewResult.DataSource = (from cd in CDs.OrderBy(x => x.YEAR).ThenBy(x => x.PRICE).ThenBy(x => x.TITLE) select cd).ToList();

            //extention method
            dataGridViewResult.DataSource = CDs.OrderBy(c => c.YEAR).ThenBy(c => c.PRICE).ThenBy(c => c.TITLE).Select(c => c).ToList();
        }



    }
}
