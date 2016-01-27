using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



namespace DataBase
{
    class DataBase
    {
        public readonly string file_name;
        public FileKey file_keys;
        public List<Index> indexes;

        public DataBase(string name_of_file)
        {
            file_name = name_of_file;
            file_keys = new FileKey(name_of_file);
            indexes = new List<Index>();
            //index = new Index(name_of_file, file_key);
        }


        public Record ReadRecord(int pos)
        {
            FileStream file = new FileStream(file_name, FileMode.Open);
            byte[] buf = new byte[file_keys.keys[pos + 1] - file_keys.keys[pos]];
            file.Seek(file_keys.keys[pos], SeekOrigin.Begin);
            file.Read(buf, 0, buf.Length);
            file.Close();
            Record record = new Record(Encoding.UTF8.GetString(buf));
            return record;
        }






    }
}
