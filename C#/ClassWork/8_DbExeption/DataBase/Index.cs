using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace DataBase
{
    class Index
    {
        public List<int> field;
        private readonly string file_name;

        public Index(string name_of_file)
        {
            file_name = name_of_file;
            field = new List<int>();
        }


        public void CreateIndex(int column_numb, FileKey file_key)
        {
            ChangeIndex(column_numb, 0, file_key);
        }


        public void ChangeIndex(int column_numb, int change_pos, FileKey file_key)
        {
            FileStream file;
            for (int i = 0; i < file_key.keys.Count; i++)
            {
                file = new FileStream(file_name, FileMode.Open);

                byte[] buf = new byte[file_key.keys[change_pos + 1] - file_key.keys[change_pos]];
                file.Seek(file_key.keys[change_pos], SeekOrigin.Begin);
                file.Read(buf, 0, buf.Length);
                Record record = new Record(Encoding.UTF8.GetString(buf));

                file.Close();

                SetRecord(i, column_numb, change_pos, record.fields[column_numb], file_key);
                change_pos++;
            }

            
        }

        private void SetRecord(int record_change_pos, int column_numb, int change_pos, string record, FileKey file_key)
        {
            FileStream file;
            if(field.Count == 0)
            {
                field.Add(record_change_pos);
                return;
            }
            //
            int begin_field = 0;
            int end_field = field.Count;

            //List<int> index = new List<int>();

            // 1st one
            
            // look for position in index

            while(true)
            {
                int current_field = (end_field - begin_field) / 2;
                

                // выделиьть в отдельный класс
                byte[] buf = new byte[file_key.keys[field[current_field] + 1] - file_key.keys[field[current_field]]];
                file = new FileStream(file_name, FileMode.Open);
                file.Seek(file_key.keys[field[current_field]], SeekOrigin.Begin);
                file.Read(buf, 0, buf.Length);
                file.Close();

                Record current_record = new Record(Encoding.UTF8.GetString(buf));

                // drelete zavisaniz na evgenii
                int compareResult = record.CompareTo(current_record.fields[column_numb]);
                if ( compareResult<0 )
                {
                    end_field = current_field;
                    if (field.Count == 2)
                    {
                        begin_field--;
                    }
                } 
                else if (compareResult>0)
                {
                    begin_field = current_field;
                    if (field.Count == 2)
                    {
                        begin_field++;
                    }
                } 
                else 
                {
                    begin_field = end_field = current_field;
                }

                // if only two left -> select one
                

                if (begin_field == end_field) 
                {
                    if (end_field == field.Count) 
                    {
                        field.Add(record_change_pos);
                    } 
                    else 
                    {
                        field.Insert(end_field, record_change_pos);
                    }

                    break;
                }
            }
        }
    }
}
