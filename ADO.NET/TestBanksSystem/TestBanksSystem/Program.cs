using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
//using BanksSystemAPI;

namespace TestBanksSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //BanksSystemAPI.BanksSystemAPI.FillDbFromSite();


            BanksSystemEntities banks = new BanksSystemEntities();

            // Add Currency
            //banks.Сurrency.Add(new Сurrency() { Name = "USD" });
            //banks.Сurrency.Add(new Сurrency() { Name = "EUR" });
            //banks.Сurrency.Add(new Сurrency() { Name = "RUB" });
            //banks.Сurrency.Add(new Сurrency() { Name = "EUR -> USD" });


            
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            WebClient wc = new WebClient();
            wc.Encoding = Encoding.UTF8;
            doc.LoadHtml(wc.DownloadString("http://myfin.by/currency/minsk"));

            int i = 1;
            int bankDepPos = 5;
            while (doc.DocumentNode.SelectNodes("//*[@id='workarea']/div[3]/div[3]/div/table/tbody/tr").Count-1 >= i)
            {
                // banks
                Bank bank = new Bank();
                foreach (HtmlAgilityPack.HtmlNode tablet in doc.DocumentNode.SelectNodes("//*[@id='workarea']/div[3]/div[3]/div/table/tbody/tr["+ i +"]"))
                {
                    foreach (HtmlAgilityPack.HtmlNode row in tablet.SelectNodes("td[1]"))
                    {
                        bank.Name = row.InnerText;
                    }
                    
                }
                i++;
                banks.Bank.Add(bank);

                // departments
                int bankDepartments = 1;
                while (doc.DocumentNode.SelectNodes("//*[@id='accordion-5']/div/div[2]/table/tbody/tr").Count >= bankDepartments)
                {
                    foreach (HtmlAgilityPack.HtmlNode tablet in doc.DocumentNode.SelectNodes("//*[@id='accordion-"+bankDepPos+"']/div/div[2]/table/tbody/tr[1]"));// + bankDepartments + "]"))
                    {
                        //foreach (HtmlAgilityPack.HtmlNode row in tablet.SelectNodes("td[1]"))
                        //{
                        //    //banks.Bank.Add(new Bank() { Name = row.InnerText });
                        //}

                    }
                    bankDepartments++;
                }
                bankDepPos++;
                i++;
                //i += 2;
            }
            //*[@id="accordion-5"]/div/div[2]/table/tbody/tr[1]
            //*[@id="accordion-5"]/div/div[2]/table/tbody/tr[2]
            //*[@id="accordion-6"]/div/div[2]/table/tbody/tr[1]

            //*[@id="accordion-5"]/div/div[2]/table/tbody/tr[1]

            //banks.Department.Add(new Department() { });

            //banks.DeprtmentsСurrencies.Add(new Department());


            //banks.SaveChanges();



            Console.ReadKey();
        }
    }
}
