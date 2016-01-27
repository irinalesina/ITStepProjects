using System;
using System.Collections.Generic;
using System.IO;



namespace DataBase
{
    class FileKey
    {
        public List<int> keys;
        private readonly string file_name;

        
        public FileKey(string name_of_file)
        {
            file_name = name_of_file;
            keys = new List<int>();
            CheckFileKey(0);
        }

        public void CheckFileKey(int check_pos)
        {
           
            if (check_pos == 0)
            {
                keys.Add(0);
            }
            FileStream file = new FileStream(file_name, FileMode.Open);

            int buf_size = 50;
            byte[] b = new byte[buf_size];
            int byte_count = buf_size;

            int lastLineSize = 0;

            while (byte_count == buf_size)
            {
                

                byte_count = file.Read(b, 0, b.Length);
                
                for(int i = 0; i < byte_count; i++)
                {

                    if (b[i] == '\n' || b[i] == '\r')
                    {
                        if (b[i + 1] == '\r' || b[i + 1] == '\n')
                        {
                            i++;
                            lastLineSize++;

                        }                       
                        keys.Add(keys[check_pos] + lastLineSize+1);
                        lastLineSize = -1;
                        check_pos++;
                    }

                    lastLineSize++;

                }
            }
            file.Close();

            
        }
    }
}
