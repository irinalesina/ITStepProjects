using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace DataBase
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path;

                Console.WriteLine("Enter path");
                path = Console.ReadLine();
                
                if(Path.GetExtension(path) != ".csv")
                {
                    throw new FormatException("You enter invalid format!");
                }



                //DataBase test = new DataBase(path);

                //Record rec = test.ReadRecord(6);

                //test.indexes.Add(new Index(path));
                //test.indexes[0].CreateIndex(0, test.file_keys);
            }
            catch(FormatException form_ex)
            {
                Console.WriteLine(form_ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }

            
        }
    }
}
