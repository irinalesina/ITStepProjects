using DataModelLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace Example4Linq2Entities
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Формирование запроса в режиме ЛЕНИВОЙ загрузки");
            var context1 = new PhoneStoreEntities();

            // Code-First поумолчанию: true, 
            // DB/ModelFirst - смотреть свойства файла EDMX

            context1.Configuration.LazyLoadingEnabled = true; 


            var query = from user in context1.Users
                        select user;
            Console.WriteLine(query);
            
            var usersList = query.ToList();

            foreach (var user in usersList)
            {
                // На каждой итерации обращение к БД!!!!
                if (user.UsersInfo != null )
                    Console.WriteLine(user.UsersInfo.FirstName);
            }
            

            Console.ReadLine();
            Console.Clear();


            Console.WriteLine("Формирование запроса в режиме ЯВНОЙ загрузки");

            var context2 = new PhoneStoreEntities();
            context2.Configuration.LazyLoadingEnabled = false;

            var query2 = from uset in context2.Users.Include("UsersInfo")
                         select uset;

            Console.WriteLine(query2);
            var usersList2 = query2.ToList();
            foreach (var user in usersList2)
            {
                //Нет запросов к БД!!!
                Console.WriteLine(user.UsersInfo.LastName);
            }



            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Формирование запроса в режиме СТРОГОЙ загрузки");

            var context3 = new PhoneStoreEntities();
            context3.Configuration.LazyLoadingEnabled = false;

            // Используется для загрузки данных из таблицы UsersInfo
            context3.UsersInfo.Load();
           
            var query3 = from user in context3.Users
                         select user;
        
             
            Console.WriteLine(query3);
            var userList3 = query3.ToList();
            
            foreach (var user in userList3)
            {
                // Нет запросов к БД! Но данные из таблицы UsersInfo 
                // должны быть загружены заранее
                Console.WriteLine(user.UsersInfo.FirstName);
            }

            Console.ReadLine();

        }
    }
}
