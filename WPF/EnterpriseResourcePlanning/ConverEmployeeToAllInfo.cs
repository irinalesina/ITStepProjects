using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace EnterpriseResourcePlanning
{
    public class ConverEmployeeToAllInfo : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value != null)
            {
                var employee = (Employee)value;
                string allInfo = "";

                allInfo += "Id: " + employee.UniqueNumber + "\n";
                allInfo += "Birthday: " + employee.Birthday.ToString("d") + "\n";
                allInfo += "Job position: " + employee.JobPosition + "\n";
                allInfo += "Place of living: " + employee.PlaceOfLiving.country + ", " +
                    employee.PlaceOfLiving.city + ", " + employee.PlaceOfLiving.street + " " + 
                    employee.PlaceOfLiving.home + " - " + employee.PlaceOfLiving.flat + "\n";
                allInfo += "Rating: " + employee.Rating + "\n";
                allInfo += "Salary: " + employee.Salary + "\n";

                return allInfo;
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return value;
        }
    }
}
