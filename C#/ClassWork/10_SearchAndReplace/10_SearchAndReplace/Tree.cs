using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _10_SearchAndReplace
{
    static class Tree
    {
        public static void Show(string dirPath, string level = "")
        {
            List<string> dirs = new List<string>(Directory.EnumerateDirectories(dirPath));

            foreach (var dir in dirs)
            {
                string str = "├";
                Console.WriteLine("{0}{1}{2}", str, level, dir.Substring(dir.LastIndexOf("\\") + 1));
                //str = "│";
                //for (int i = 0; i < level.Length - 1; i++)
                //{
                //    str += " ";
                //}
                //str += "└";
                //Console.WriteLine(str);
                Show(dir, level + "─");
            }

            var files = Directory.EnumerateFiles(dirPath);
            foreach (var file in files)
            {
                string level_folder = "", str = "│"; ;
                for(int i = 0; i < level.Length + 2; i++)
                {
                    level_folder += " ";
                }
                var file_name = file.Substring(dirPath.Length + 1);
                Console.WriteLine("{0}{1}{2}",str, level_folder , file_name);
            }
            //Console.WriteLine("{0} directories found.", dirs.Count);
        }

        public static void FindString(string str)
        {

        }
    }
}
