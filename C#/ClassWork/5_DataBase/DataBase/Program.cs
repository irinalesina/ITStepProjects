using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DataBase
{
    class Program
    {
        static void Main(string[] args)
        {
            DataBase test = new DataBase("test.txt");

            Record rec = test.ReadRecord(6);

            test.indexes.Add(new Index("test.txt"));
            test.indexes[0].CreateIndex(0, test.file_keys);

            Console.ReadKey();
        }
    }
}
