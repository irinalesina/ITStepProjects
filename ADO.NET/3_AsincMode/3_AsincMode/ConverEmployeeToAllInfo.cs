using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace _3_AsincMode
{
    class ConverEmployeeToAllInfo : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value != null)
            {
                var employee = (Employee)value;
                string allInfo = "";

                allInfo += "Birthday: " + employee.Birthday + "\n";

                allInfo += "Address: " + employee.Address + "\n";

                allInfo += "Phone: " + employee.Phone + "\n";

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
