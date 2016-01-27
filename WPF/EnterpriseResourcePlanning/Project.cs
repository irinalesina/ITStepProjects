using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseResourcePlanning
{
    public class Project
    {
        private string projectName;
        public string ProjectName
        {
            get { return projectName; }
            set { projectName = value; }
        }


        private string customer;
        public string Customer
        {
            get { return customer; }
            set { customer = value; }
        }


        private DateTime begin;
        public DateTime Begin
        {
            get { return begin; }
            set { begin = value; }
        }


        private DateTime end;
        public DateTime End
        {
            get { return end; }
            set { end = value; }
        }
    }
}
