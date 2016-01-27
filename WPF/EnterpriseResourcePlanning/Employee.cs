using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace EnterpriseResourcePlanning
{
    public class Employee
    {
        private static int counterForUniqueNumber = 0;


        // unique datas
        private int uniqueNumber;
        public int UniqueNumber
        {
            get
            {
                return uniqueNumber;
            }
            set { }
        }


        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            set
            {
                if(firstName == null)
                {
                    firstName = value;
                }
            }
        }

        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set 
            { 
                if(lastName == null)
                {
                    lastName = value; 

                }
            }
        }


        private DateTime birthday;
        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }


        private Address placeOfLiving;
        public Address PlaceOfLiving
        {
            get { return placeOfLiving; }
            set { placeOfLiving = value; }
        }


        private string photo;
        public string Photo
        {
            get { return photo; }
            set { photo = value; }
        }


        // business qualities
        private string jobPosition;
        public string JobPosition
        {
            get { return jobPosition; }
            set { jobPosition = value; }
        }


        private int salary;
        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }


        private int rating;

        public int Rating
        {
            get { return rating; }
            set { rating = value; }
        }

         private Dictionary<string, int> qualities;

        public Dictionary<string, int> Qualities
        {
            get { return qualities; }
            set { qualities = value; }
        }
            

        private List<Project> projects;
        public List<Project> Projects
        {
            get { return projects; }
            set { projects = value; }
        }

        
        public Employee()
        {
            uniqueNumber = ++counterForUniqueNumber;
        }
    }

}
