using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EnterpriseResourcePlanning
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static List<Project> allProjects = new List<Project>()
        {
            new Project(){ ProjectName = "Project_1", Customer = "Company_1", Begin = new DateTime(2012, 02, 17), End = new DateTime(2014, 07, 03) },
            new Project(){ ProjectName = "Project_2", Customer = "Company_2", Begin = new DateTime(2012, 11, 25), End = new DateTime(2013, 03, 14) },
            new Project(){ ProjectName = "Project_3", Customer = "Company_3", Begin = new DateTime(2014, 03, 07), End = new DateTime(2014, 10, 26) },
            new Project(){ ProjectName = "Project_4", Customer = "Company_4", Begin = new DateTime(2015, 05, 22) },
            new Project(){ ProjectName = "Project_5", Customer = "Company_5", Begin = new DateTime(2014, 09, 11) }
        };

        public static List<Employee> employees = new List<Employee>()
        { 
            new Employee() 
            {
                FirstName = "Alex", 
                LastName = "Glass", 
                Photo = "../../Images/AlexGlass.jpg", 
                Projects = new List<Project>(){ allProjects[0] }, 
                Qualities = new Dictionary<string, int>()
                {
                    {"Effective job", 85},
                    {"The percentage of successfully completed projects", 70},
                    {"Efficiency teamwork", 40}, 
                    {"The percentage of delays", 10},
                    {"Creativity", 30}
                },
                Birthday = new DateTime(1991, 06, 17),
                JobPosition = "C++ developer",
                PlaceOfLiving = new Address()
                {
                    country = "Belarus",
                    city = "Minsk",
                    street = "Kulman",
                    home = "21",
                    flat = "11"
                },
                Rating = 57,
                Salary = 1550
            }, 

            new Employee() 
            { 
                FirstName = "Max", 
                LastName = "Belov", 
                Photo = "../../Images/MaxBelov.jpg", 
                Projects = new List<Project>(){ allProjects[0], allProjects[2] }, 
                Qualities = new Dictionary<string, int>()
                { 
                    {"Effective job", 90}, 
                    {"The percentage of successfully completed projects", 100},
                    {"Efficiency teamwork", 95}, 
                    {"The percentage of delays", 0}, 
                    {"Creativity", 70} 
                },
                Birthday = new DateTime(1986, 10, 23),
                JobPosition = "C# developer",
                PlaceOfLiving = new Address()
                {
                    country = "Belarus",
                    city = "Minsk",
                    street = "Rafieva",
                    home = "18",
                    flat = "158"
                },
                Rating = 12,
                Salary = 1100
            },

            new Employee() 
            {
                FirstName = "Nick", 
                LastName = "Mor", 
                Photo = "../../Images/NickMor.jpg", 
                Projects = new List<Project>(){ allProjects[3] },
                Qualities = new Dictionary<string, int>()
                { 
                    {"Effective job", 50}, 
                    {"The percentage of successfully completed projects", 50},
                    {"Efficiency teamwork", 60}, 
                    {"The percentage of delays", 20}, 
                    {"Creativity", 60} 
                },
                Birthday = new DateTime(1993, 03, 28),
                JobPosition = "System administrator",
                PlaceOfLiving = new Address()
                {
                    country = "Belarus",
                    city = "Minsk",
                    street = "Tolbuhina",
                    home = "78",
                    flat = "56"
                },
                Rating = 10,
                Salary = 850
            }, 

            new Employee() 
            { 
                FirstName = "Sam", 
                LastName = "Bloom", 
                Photo = "../../Images/SamBloom.jpg", 
                Projects = new List<Project>(){ allProjects[1], allProjects[4] },
                Qualities = new Dictionary<string, int>()
                { 
                    {"Effective job", 80}, 
                    {"The percentage of successfully completed projects", 75},
                    {"Efficiency teamwork", 70}, 
                    {"The percentage of delays", 50}, 
                    {"Creativity", 80} 
                },
                Birthday = new DateTime(1994, 09, 06),
                JobPosition = "HR",
                PlaceOfLiving = new Address()
                {
                    country = "Belarus",
                    city = "Minsk",
                    street = "Bogdanovicha",
                    home = "158",
                    flat = "270"
                },
                Rating = 28,
                Salary = 700
            }
        };

        public List<Employee> Employees 
        {
            get { return employees; }
            set { }
        }

        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
