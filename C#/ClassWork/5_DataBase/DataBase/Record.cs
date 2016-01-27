using System;
using System.Collections.Generic;
using System.IO;

namespace DataBase
{
    class Record
    {
        public string[] fields;


        public Record(string record)
        {
            fields = record.TrimEnd(new Char[] { '\n', '\r' }).Split(new Char[] { ';' });
        }


        public Record() { }

    }
}
