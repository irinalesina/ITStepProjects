using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace TaskManager.Converters
{
    public class BytesToKilobytesStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            long bytes = System.Convert.ToInt64(value);
            return (bytes / 1000) + " Kb";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string kbString = (string)value;
            int kbytes = int.Parse(kbString.Split(new char[] { ' ' })[0]);
            return kbytes * 1000;
        }
    }
}
