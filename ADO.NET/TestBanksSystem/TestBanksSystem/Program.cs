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
            BanksSystemEntities banks = new BanksSystemEntities();

            // Add Currency
            banks.Сurrency.Add(new Сurrency() { Name = "USD" });
            banks.Сurrency.Add(new Сurrency() { Name = "EUR" });
            banks.Сurrency.Add(new Сurrency() { Name = "RUB" });
            banks.Сurrency.Add(new Сurrency() { Name = "EUR -> USD" });


            Bank bank = new Bank() { Name="SomeName" };

            banks.Bank.Add(bank);




            Console.ReadKey();
        }
    }
}
