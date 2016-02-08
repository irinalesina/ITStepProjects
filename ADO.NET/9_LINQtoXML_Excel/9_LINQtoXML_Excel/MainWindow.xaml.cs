using LinqToExcel;
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
using System.Xml.Linq;

namespace _9_LINQtoXML_Excel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.WriteDataFromExcelToXML();
            InitializeComponent();
        }

        public void WriteDataFromExcelToXML()
        {
            XDocument doc = new XDocument();
            doc.Add(new XElement("Store"));

            string pathFile = "../../PriceProductBase.xlsx";
            var excelFile = new ExcelQueryFactory(pathFile);

            foreach (var item in excelFile.GetWorksheetNames())
            {
                var category = new XElement(item);
                List<Row> elements;

                if (item == "Prices")
                {
                    elements = (from a in excelFile.Worksheet(item) where a["КодТовара"] != "" select a).Take(5).ToList();
                }
                else
                {
                    elements = (from a in excelFile.Worksheet(item) select a).Take(5).ToList();
                }

                foreach (var el in elements)
                {
                    XElement element = new XElement("Element");
                    foreach(var itemRow in excelFile.GetColumnNames(item))
                    {
                        XElement data = new XElement(itemRow);
                        data.Value = el[itemRow];
                        element.Add(data);
                    }
                    category.Add(element);
                }

                doc.Root.Add(category);
            }

            excelFile.ReadOnly = true;

            doc.Save("PriceProductBase.xml");
        }
    }
}
