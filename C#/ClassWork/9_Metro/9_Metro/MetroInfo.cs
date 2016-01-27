using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace _9_Metro
{
    [Serializable]
    public class MetroInfo
    {
        public MetroInfo() { }

        public static void Serialize(string path)
        {
            //// передаем в конструктор тип класса
            //XmlSerializer writer = new XmlSerializer(typeof(MetroInfo));

            //// получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                XmlWriter wr = XmlWriter.Create(fs);

                wr.WriteStartElement("meta");
                wr.WriteAttributeString("http-equiv", "refresh");
                wr.WriteAttributeString("content", "0.251");


                wr.WriteStartElement("svg");
                wr.WriteAttributeString("width", "800");
                wr.WriteAttributeString("height", "500");

                int current_pos = 0;
                int r = 20;
                foreach(var st in Program.stations)
                {
                    wr.WriteStartElement("text");
                    wr.WriteAttributeString("fill", "#008AB8");
                    wr.WriteAttributeString("x", current_pos.ToString());
                    wr.WriteAttributeString("y", r.ToString());
                    wr.WriteString(st.name);
                    wr.WriteEndElement();

                    wr.WriteStartElement("text");
                    wr.WriteAttributeString("fill", "#008AB8");
                    wr.WriteAttributeString("x", (r + current_pos).ToString());
                    wr.WriteAttributeString("y", (r * 5).ToString());
                    wr.WriteString(st.passengers_queue.Count.ToString());
                    wr.WriteEndElement();

                    wr.WriteStartElement("circle");
                    wr.WriteAttributeString("fill", "#CCFFFF");
                    wr.WriteAttributeString("cx", (r + current_pos).ToString());
                    wr.WriteAttributeString("cy", (r * 3).ToString());
                    wr.WriteAttributeString("r", r.ToString());
                    wr.WriteEndElement();

                    foreach (var tr in Program.transports)
                    {
                        wr.WriteStartElement("circle");
                        wr.WriteAttributeString("fill", tr.color);
                        int actual_dist = 0, dist = 0;
                        foreach (var s in Program.stations)
                        {
                            actual_dist += r;
                            if(dist == tr.traveled_distance)
                            {
                                break;
                            }
                            actual_dist += r;
                            dist += (int)s.time_to_next_station;
                            if (dist < tr.traveled_distance)
                            {
                                actual_dist += (int)s.time_to_next_station;
                            }
                            else
                            {
                                break;
                            }
                        }
                        wr.WriteAttributeString("cx", (actual_dist + (int)tr.traveled_distance).ToString());
                        wr.WriteAttributeString("cy", (r * 3).ToString());
                        wr.WriteAttributeString("r", "5");
                        wr.WriteEndElement();
                    }

                    current_pos += r * 2;

                    wr.WriteStartElement("line");
                    wr.WriteAttributeString("style", "stroke:rgb(154,168,7);stroke-width:5");
                    wr.WriteAttributeString("x1", current_pos.ToString());
                    wr.WriteAttributeString("x2", (current_pos + (int)st.time_to_next_station).ToString());
                    wr.WriteAttributeString("y1", (r * 3).ToString());
                    wr.WriteAttributeString("y2", (r * 3).ToString());
                    wr.WriteEndElement();

                    current_pos += (int)st.time_to_next_station;
                }
                
                wr.WriteEndElement();
                wr.Flush();
            }
        }
    }
}
