using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Junctions
{
    public partial class Form1 : Form
    {
        public static List<Junction> junctions = new List<Junction>();
        public static Roads roads = new Roads();
        public static List<Car> cars = new List<Car>();

        private static double currentTime = 0;

        public static double CurrentTime
        {
            get
            {
                return currentTime;
            }
        }

        

        public Form1()
        {
            InitializeComponent();

            this.SetStyle(
                System.Windows.Forms.ControlStyles.UserPaint |
                System.Windows.Forms.ControlStyles.AllPaintingInWmPaint |
                System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer,
                true);

            CreateMap();


            int amountOfCars = 100;
            for (int j = 0; j < amountOfCars; ++j)
            {
                cars.Add(new Car());
            }
        }

        private void SortRoads()
        {
            //foreach(var )
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen penForRoads = new Pen(Color.Black, 16);
            SolidBrush brushForCars = new SolidBrush(Color.Orange);
            SolidBrush brushForJunctions = new SolidBrush(Color.Black);

            foreach (Road road in roads)
            {
                e.Graphics.DrawLine(penForRoads, road.junc1.x, road.junc1.y,
                    road.junc2.x, road.junc2.y);
            }

            foreach (Junction junc in junctions)
            {
                e.Graphics.FillEllipse(brushForJunctions, new Rectangle(junc.x - 8, junc.y - 8, 16, 16));
            }

            foreach (Road road in roads)
            {
                for (int i = 0; i < road.relatedCars.Count; )
                {
                    int lengthInXAxis = road.relatedCars[i].to.x - road.relatedCars[i].from.x;
                    int lengthInYAxis = road.relatedCars[i].to.y - road.relatedCars[i].from.y;

                    int x = (int)((lengthInXAxis / (road.relatedCars[i].arrivalTime - road.relatedCars[i].departureTime)) *
                        (Form1.CurrentTime - road.relatedCars[i].departureTime) + road.relatedCars[i].from.x);
                    int y = (int)((lengthInYAxis / (road.relatedCars[i].arrivalTime - road.relatedCars[i].departureTime)) *
                        (Form1.CurrentTime - road.relatedCars[i].departureTime) + road.relatedCars[i].from.y);

                    if (Form1.CurrentTime >= road.relatedCars[i].arrivalTime)
                    {
                        road.relatedCars[i].makeDecision();
                    }
                    else
                    {
                        double shift_x = 4 * Math.Cos(road.azimuth) * (-1);
                        double shift_y = 4 * Math.Sin(road.azimuth);

                        e.Graphics.FillEllipse(brushForCars, x - 4 + (int)shift_x, y - 4 + (int)shift_y, 8, 8);
                        ++i;
                    }
                }
            }
        }

        private void timerForMakingDecisions_Tick(object sender, EventArgs e)
        {
            this.Refresh();
            currentTime += 0.2;
        }

        public void CreateMap()
        {
            int add = 0;
            int load = 5;
            //Kolya

            junctions.Add(new Junction(15, this.ClientRectangle.Height - 15)); //1 точка 
            junctions.Add(new Junction(15 + 20, this.ClientRectangle.Height - 15)); // 2 точка 
            junctions.Add(new Junction(15 + 80, this.ClientRectangle.Height - 15)); //3 точка 
            junctions.Add(new Junction(15 + 80, this.ClientRectangle.Height - 15 - 30)); //4 точка 
            junctions.Add(new Junction(15 + 60, this.ClientRectangle.Height - 15 - 30)); //5 точка 
            junctions.Add(new Junction(15 + 20, this.ClientRectangle.Height - 15 - 30)); //6 точка 
            junctions.Add(new Junction(15, this.ClientRectangle.Height - 15 - 30)); //7 точка 
            junctions.Add(new Junction(15 + 60, this.ClientRectangle.Height - 15 - 50)); //8 точка 
            junctions.Add(new Junction(15 + 80, this.ClientRectangle.Height - 15 - 50)); //9 точка 
            junctions.Add(new Junction(15 + 120, this.ClientRectangle.Height - 15 - 50)); //10 точка 
            junctions.Add(new Junction(15 + 120, this.ClientRectangle.Height - 15 - 70)); //11 точка 
            junctions.Add(new Junction(15 + 80, this.ClientRectangle.Height - 15 - 70)); //12 точка 
            junctions.Add(new Junction(15 + 20, this.ClientRectangle.Height - 15 - 70)); //13 точка 
            junctions.Add(new Junction(15 + 80, this.ClientRectangle.Height - 15 - 90)); //14 точка 
            junctions.Add(new Junction(15 + 40, this.ClientRectangle.Height - 15 - 90)); //15 точка 
            junctions.Add(new Junction(15, this.ClientRectangle.Height - 15 - 110)); //16 точка 
            junctions.Add(new Junction(15 + 40, this.ClientRectangle.Height - 15 - 110)); //17 точка 
            junctions.Add(new Junction(15 + 80, this.ClientRectangle.Height - 15 - 110)); //18 точка 
            junctions.Add(new Junction(15 + 120, this.ClientRectangle.Height - 15 - 110)); //19 точка 
            junctions.Add(new Junction(15 + 120, this.ClientRectangle.Height - 15 - 150)); //20 точка 
            junctions.Add(new Junction(15 + 80, this.ClientRectangle.Height - 15 - 150)); //21 точка 
            junctions.Add(new Junction(15 + 40, this.ClientRectangle.Height - 15 - 150)); //22 точка 
            junctions.Add(new Junction(15 + 120, this.ClientRectangle.Height - 15 - 170)); //23 точка 
            junctions.Add(new Junction(15 + 40, this.ClientRectangle.Height - 15 - 170)); //24 точка 
            junctions.Add(new Junction(15, this.ClientRectangle.Height - 15 - 170)); //25 точка 


            roads.Add(junctions[0], junctions[1], 70, load); // 1-2 
            roads.Add(junctions[1], junctions[2], 70, load); // 2-3 
            roads.Add(junctions[2], junctions[3], 70, load); // 3-4 
            roads.Add(junctions[3], junctions[4], 70, load); // 4-5 
            roads.Add(junctions[4], junctions[5], 70, load); // 5-6 
            roads.Add(junctions[5], junctions[6], 70, load); // 6-7 
            roads.Add(junctions[6], junctions[0], 70, load); // 7-1 
            roads.Add(junctions[5], junctions[1], 70, load); // 6-2 
            roads.Add(junctions[3], junctions[8], 70, load); // 4-9 
            roads.Add(junctions[4], junctions[7], 70, load); // 8-5 
            roads.Add(junctions[8], junctions[7], 70, load); // 8-7 
            roads.Add(junctions[8], junctions[9], 70, load); // 9-10 
            roads.Add(junctions[10], junctions[9], 70, load); // 10-11 
            roads.Add(junctions[10], junctions[11], 70, load); // 12-11 
            roads.Add(junctions[8], junctions[11], 70, load); // 12-9 
            roads.Add(junctions[12], junctions[11], 70, load); // 12-13 
            roads.Add(junctions[12], junctions[5], 70, load); // 6-13 
            roads.Add(junctions[13], junctions[11], 70, load); // 14-12 
            roads.Add(junctions[14], junctions[13], 70, load); // 15-14 
            roads.Add(junctions[16], junctions[14], 70, load); // 17-15 
            roads.Add(junctions[15], junctions[6], 70, load); // 16-7 
            roads.Add(junctions[15], junctions[24], 70, load); // 16-25 
            roads.Add(junctions[23], junctions[24], 70, load); // 24-25 
            roads.Add(junctions[23], junctions[22], 70, load); // 24-23 
            roads.Add(junctions[19], junctions[22], 70, load); // 23-20 
            roads.Add(junctions[19], junctions[18], 70, load); // 19-20 
            roads.Add(junctions[10], junctions[18], 70, load); // 11-19 
            roads.Add(junctions[19], junctions[20], 70, load); // 20-21 
            roads.Add(junctions[21], junctions[20], 70, load); // 22-21 
            roads.Add(junctions[21], junctions[16], 70, load); // 22-17 
            roads.Add(junctions[23], junctions[21], 70, load); // 24-22 
            roads.Add(junctions[16], junctions[17], 70, load); // 17-18 
            roads.Add(junctions[17], junctions[18], 70, load); // 18-19 
            roads.Add(junctions[15], junctions[16], 70, load); // 16-17 
            roads.Add(junctions[20], junctions[17], 70, load); // 21-18

            add = junctions.Count;

            //Olya

            //0
            junctions.Add(new Junction(160 + 15, this.ClientRectangle.Height - 15));
            //1
            junctions.Add(new Junction(160 + 15, this.ClientRectangle.Height - 15 - 30));
            //2
            junctions.Add(new Junction(160 + 15, this.ClientRectangle.Height - 15 - 80));
            //3
            junctions.Add(new Junction(160 + 15, this.ClientRectangle.Height - 15 - 110));
            //4
            junctions.Add(new Junction(140 + 15, this.ClientRectangle.Height - 15 - 110));
            //5
            junctions.Add(new Junction(140 + 15, this.ClientRectangle.Height - 15 - 150));
            //6
            junctions.Add(new Junction(160 + 15, this.ClientRectangle.Height - 15 - 150));
            //7
            junctions.Add(new Junction(160 + 15, this.ClientRectangle.Height - 15 - 170));
            //8
            junctions.Add(new Junction(200 + 15, this.ClientRectangle.Height - 15 - 170));
            //9
            junctions.Add(new Junction(200 + 15, this.ClientRectangle.Height - 15 - 150));
            //10
            junctions.Add(new Junction(200 + 15, this.ClientRectangle.Height - 15 - 110));
            //11
            junctions.Add(new Junction(200 + 15, this.ClientRectangle.Height - 15 - 80));
            //12
            junctions.Add(new Junction(200 + 15, this.ClientRectangle.Height - 15 - 30));
            //13
            junctions.Add(new Junction(200 + 15, this.ClientRectangle.Height - 15));

            int kolya = add;
            //0-1
            roads.Add(junctions[0 + kolya], junctions[1 + kolya], 70, load);
            //0-13
            roads.Add(junctions[0 + kolya], junctions[13 + kolya], 70, load);
            //1-2
            roads.Add(junctions[1 + kolya], junctions[2 + kolya], 70, load);
            //1-12
            roads.Add(junctions[1 + kolya], junctions[12 + kolya], 70, load);
            //2-3
            roads.Add(junctions[2 + kolya], junctions[3 + kolya], 70, load);
            //2-11
            roads.Add(junctions[2 + kolya], junctions[11 + kolya], 70, load);
            //3-4
            roads.Add(junctions[3 + kolya], junctions[4 + kolya], 70, load);
            //3-10
            roads.Add(junctions[3 + kolya], junctions[10 + kolya], 70, load);
            //4-5
            roads.Add(junctions[4 + kolya], junctions[5 + kolya], 70, load);
            //5-6
            roads.Add(junctions[5 + kolya], junctions[6 + kolya], 70, load);
            //6-7
            roads.Add(junctions[6 + kolya], junctions[7 + kolya], 70, load);
            //6-9
            roads.Add(junctions[6 + kolya], junctions[9 + kolya], 70, load);
            //7-8
            roads.Add(junctions[7 + kolya], junctions[8 + kolya], 70, load);
            //8-9
            roads.Add(junctions[8 + kolya], junctions[9 + kolya], 70, load);
            //9-10
            roads.Add(junctions[9 + kolya], junctions[10 + kolya], 70, load);
            //10-11
            roads.Add(junctions[10 + kolya], junctions[11 + kolya], 70, load);
            //11-12
            roads.Add(junctions[11 + kolya], junctions[12 + kolya], 70, load);
            //12-13
            roads.Add(junctions[12 + kolya], junctions[13 + kolya], 70, load);

            add = junctions.Count;

            //Ira

            //junctions

            //1
            junctions.Add(new Junction(280 + 15, this.ClientRectangle.Height - 15));
            //2
            junctions.Add(new Junction(420 + 15, this.ClientRectangle.Height - 15));

            //3
            junctions.Add(new Junction(420 + 15, this.ClientRectangle.Height - 15 - 30));
            //4
            junctions.Add(new Junction(360 + 15, this.ClientRectangle.Height - 15 - 30));
            //5
            junctions.Add(new Junction(320 + 15, this.ClientRectangle.Height - 15 - 30));
            //6
            junctions.Add(new Junction(280 + 15, this.ClientRectangle.Height - 15 - 30));

            //7
            junctions.Add(new Junction(300 + 15, this.ClientRectangle.Height - 15 - 50));
            //8
            junctions.Add(new Junction(320 + 15, this.ClientRectangle.Height - 15 - 50));
            //9
            junctions.Add(new Junction(360 + 15, this.ClientRectangle.Height - 15 - 50));
            //10
            junctions.Add(new Junction(380 + 15, this.ClientRectangle.Height - 15 - 50));

            //11
            junctions.Add(new Junction(420 + 15, this.ClientRectangle.Height - 15 - 70));
            //12
            junctions.Add(new Junction(380 + 15, this.ClientRectangle.Height - 15 - 70));
            //13
            junctions.Add(new Junction(320 + 15, this.ClientRectangle.Height - 15 - 70));

            //14
            junctions.Add(new Junction(320 + 15, this.ClientRectangle.Height - 15 - 90));
            //15
            junctions.Add(new Junction(350 + 15, this.ClientRectangle.Height - 15 - 90));

            //16
            junctions.Add(new Junction(320 + 15, this.ClientRectangle.Height - 15 - 110));
            //17
            junctions.Add(new Junction(300 + 15, this.ClientRectangle.Height - 15 - 110));

            //18
            junctions.Add(new Junction(280 + 15, this.ClientRectangle.Height - 15 - 130));
            //19
            junctions.Add(new Junction(320 + 15, this.ClientRectangle.Height - 15 - 130));
            //20
            junctions.Add(new Junction(350 + 15, this.ClientRectangle.Height - 15 - 130));
            //21
            junctions.Add(new Junction(380 + 15, this.ClientRectangle.Height - 15 - 130));
            //22
            junctions.Add(new Junction(420 + 15, this.ClientRectangle.Height - 15 - 130));

            //23
            junctions.Add(new Junction(420 + 15, this.ClientRectangle.Height - 15 - 170));
            //24
            junctions.Add(new Junction(380 + 15, this.ClientRectangle.Height - 15 - 170));
            //25
            junctions.Add(new Junction(320 + 15, this.ClientRectangle.Height - 15 - 170));
            //26
            junctions.Add(new Junction(280 + 15, this.ClientRectangle.Height - 15 - 170));


            //roads

            //1-2
            roads.Add(junctions[0 + add], junctions[1 + add], 70, load);/////////////
            //1-6
            roads.Add(junctions[0 + add], junctions[5 + add], 70, load);
            //2-3
            roads.Add(junctions[1 + add], junctions[2 + add], 70, load);

            //6-5
            roads.Add(junctions[5 + add], junctions[4 + add], 70, load);
            //5-4
            roads.Add(junctions[4 + add], junctions[3 + add], 70, load);
            //4-3
            roads.Add(junctions[3 + add], junctions[2 + add], 70, load);
            //6-18
            roads.Add(junctions[5 + add], junctions[17 + add], 70, load);////////
            //5-8
            roads.Add(junctions[4 + add], junctions[7 + add], 70, load);
            //4-9
            roads.Add(junctions[3 + add], junctions[8 + add], 70, load);
            //3-11
            roads.Add(junctions[2 + add], junctions[10 + add], 70, load);

            //7-8
            roads.Add(junctions[6 + add], junctions[7 + add], 70, load);
            //9-10
            roads.Add(junctions[8 + add], junctions[9 + add], 70, load);
            //7-17
            roads.Add(junctions[6 + add], junctions[16 + add], 70, load);
            //8-13
            roads.Add(junctions[7 + add], junctions[12 + add], 70, load);
            //10-12
            roads.Add(junctions[9 + add], junctions[11 + add], 70, load);

            //13-12
            roads.Add(junctions[12 + add], junctions[11 + add], 70, load);
            //12-11
            roads.Add(junctions[11 + add], junctions[10 + add], 70, load);
            //13-14
            roads.Add(junctions[12 + add], junctions[13 + add], 70, load);
            //12-21
            roads.Add(junctions[11 + add], junctions[20 + add], 70, load);
            //11-22
            roads.Add(junctions[10 + add], junctions[21 + add], 70, load);

            //14-15
            roads.Add(junctions[13 + add], junctions[14 + add], 70, load);
            //14-16
            roads.Add(junctions[13 + add], junctions[15 + add], 70, load);
            //15-20
            roads.Add(junctions[14 + add], junctions[19 + add], 70, load);

            //17-16
            roads.Add(junctions[16 + add], junctions[15 + add], 70, load);
            //16-19
            roads.Add(junctions[15 + add], junctions[18 + add], 70, load);

            //18-19
            roads.Add(junctions[17 + add], junctions[18 + add], 70, load);
            //19-20
            roads.Add(junctions[18 + add], junctions[19 + add], 70, load);
            //20-21
            roads.Add(junctions[19 + add], junctions[20 + add], 70, load);
            //21-22
            roads.Add(junctions[20 + add], junctions[21 + add], 70, load);
            //18-26
            roads.Add(junctions[17 + add], junctions[25 + add], 70, load);
            //19-25
            roads.Add(junctions[18 + add], junctions[24 + add], 70, load);
            //21-24
            roads.Add(junctions[20 + add], junctions[23 + add], 70, load);
            //22-23
            roads.Add(junctions[21 + add], junctions[22 + add], 70, load);

            //26-25
            roads.Add(junctions[25 + add], junctions[24 + add], 70, load);
            //25-24
            roads.Add(junctions[24 + add], junctions[23 + add], 70, load);
            //24-23
            roads.Add(junctions[23 + add], junctions[22 + add], 70, load);


            //push Kolya + Olya

            //3-0
            roads.Add(junctions[2], junctions[0 + kolya], 70, load);
            //4-1
            roads.Add(junctions[3], junctions[1 + kolya], 70, load);
            //19-4
            roads.Add(junctions[18], junctions[4 + kolya], 70, load);
            //23-7
            roads.Add(junctions[22], junctions[7 + kolya], 70, load);


            //push Olya + Ira

            //13-1
            roads.Add(junctions[13 + kolya], junctions[0 + add], 70, load);
            //12-6
            roads.Add(junctions[12 + kolya], junctions[5 + add], 70, load);
            //8-26
            roads.Add(junctions[8 + kolya], junctions[25 + add], 70, load);

            //add scale
            int i = 0;
            int scale = 3;
            foreach (var junk in junctions)
            {
                junk.x = junk.x * 2 / 3 * scale;
                junk.y = junk.y * 2 / 3 * scale;
                i++;
            }
        }
    }
}
