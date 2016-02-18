using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BanksSystemAPI
{
    public static class BanksSystemAPI
    {
        static BanksSystemEntities banks = new BanksSystemEntities();

        public static void FillDbFromSite()
        {
            // Add Currency
            banks.Сurrency.Add(new Сurrency() { Name = "USD" });
            banks.Сurrency.Add(new Сurrency() { Name = "EUR" });
            banks.Сurrency.Add(new Сurrency() { Name = "RUB" });
            banks.Сurrency.Add(new Сurrency() { Name = "EUR -> USD" });

            //Add Banks
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            WebClient wc = new WebClient();
            wc.Encoding = Encoding.UTF8;
            doc.LoadHtml(wc.DownloadString("http://myfin.by/currency/minsk"));

            foreach (HtmlAgilityPack.HtmlNode tablet in doc.DocumentNode.SelectNodes("//*[@id='workarea']/div[3]/div[3]/div/table/tbody/tr[1]"))
            {
                foreach (HtmlAgilityPack.HtmlNode row in tablet.SelectNodes("td[1]"))
                {
                    banks.Bank.Add(new Bank() { Name = row.InnerText });
                }
            }

            
            //banks.Department.Add(new Department() { });

            //banks.DeprtmentsСurrencies.Add(new Department());


            banks.SaveChanges();
        }
    }
}
