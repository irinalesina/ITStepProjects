using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace EnterpriseResourcePlanning
{
    public class ConvertDateTimeToDate : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value != null )
            {
                var date = ((DateTime)value).Date.ToString("d");
                if (String.Compare(date, "01.01.0001") == 0)
                {
                    return "not completed";
                }
                return date;
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return value;
        }
    }
}
