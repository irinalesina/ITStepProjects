using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace TaskManager.Converters
{
    public class ProcessToInfoConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string info = "Process info:\n\n";
            Process selectedProcess = (Process)value;

            if (selectedProcess != null)
            {
                try
                {
                    info += "Процесс: " + selectedProcess.ProcessName + "\n";
                    info += "Память: " + selectedProcess.WorkingSet64 / 1000 + " Кб\n";
                    info += "Базовый приоритет: " + selectedProcess.BasePriority + "\n";
                    info += "Идентификатор сеанса служб: " + selectedProcess.SessionId + "\n";
                    info += "Выгружаемая память: " + selectedProcess.PagedSystemMemorySize64 / 1000 + " Кб\n";
                    info += "Невыгружаемая память: " + selectedProcess.NonpagedSystemMemorySize64 / 1000 + " Кб\n";
                    info += "Максимальный объем памяти в файле подкачки: " + selectedProcess.PeakPagedMemorySize64 / 1000 + " Кб\n";
                    info += "Максимальный объем виртуальной памяти: " + selectedProcess.PeakVirtualMemorySize64 + " Кб\n";
                    info += "Закрытая память: " + selectedProcess.PrivateMemorySize64 + " Кб\n";
                    info += "Дата и время запуска: " + selectedProcess.StartTime + "\n";
                    info += "Полное время процессора: " + selectedProcess.TotalProcessorTime + "\n";
                    info += "Пользовательское время процессора: " + selectedProcess.UserProcessorTime + "\n";
                }
                catch (Exception e)
                {
                    info += e.Message;
                }
            }

            return info;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}