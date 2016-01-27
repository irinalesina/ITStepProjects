using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;




namespace SchoolJournal
{
    [Serializable]
    public class MySortedDictionary<key, value> : IEnumerable<KeyValuePair<key, value>>, IXmlSerializable
    {
        public IEnumerator<KeyValuePair<key, value>> GetEnumerator()
        {
            return sort_dict.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        // storage
        private SortedDictionary<key, value> sort_dict;


        public MySortedDictionary()
        {
            sort_dict = null;
        }


        public value this[key index]
        {
            get
            {
                return sort_dict[index];
            }
            set
            {
                sort_dict[index] = value;
            }
        }


        public void Add(key k, value v)
        {
            if (sort_dict == null)
            {
                sort_dict = new SortedDictionary<key, value>();
            }
            sort_dict.Add(k, v);
        }


        public void Add(System.Object obj)
        {
            Console.WriteLine(obj.ToString());
        }


        public void WriteXml(XmlWriter writer)
        {
            XmlSerializer serializer_key = new XmlSerializer(typeof(key));
            XmlSerializer serializer_value = new XmlSerializer(typeof(value));

            foreach (var sd in sort_dict)
            {
                writer.WriteStartElement("Key");
                serializer_key.Serialize(writer, sd.Key);
                writer.WriteEndElement();

                writer.WriteStartElement("Value");
                serializer_value.Serialize(writer, sd.Value);
                writer.WriteEndElement();
            }
        }

        public void ReadXml(XmlReader reader)
        {
            reader.ReadStartElement();

            XmlSerializer keySerializer = new XmlSerializer(typeof(key));
            XmlSerializer valueSerializer = new XmlSerializer(typeof(value));
            key keyBuffer;
            value valueBuffer;

            while (reader.NodeType != XmlNodeType.EndElement)
            {
                reader.ReadStartElement();
                keyBuffer = (key)keySerializer.Deserialize(reader);
                reader.ReadEndElement();

                reader.ReadStartElement();
                valueBuffer = (value)valueSerializer.Deserialize(reader);
                reader.ReadEndElement();

                this.Add(keyBuffer, valueBuffer);
            }

            reader.ReadEndElement();

        }

        public XmlSchema GetSchema()
        {
            return (null);
        }
    }

}
