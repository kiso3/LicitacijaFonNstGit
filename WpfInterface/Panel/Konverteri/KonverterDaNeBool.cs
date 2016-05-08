using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WpfInterface3.Panel.TablePanel
{
    [ValueConversion(typeof(bool), typeof(bool))]
    public class KonverterDaNeBool : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var boolValue = value is bool && (bool)value;

            return boolValue ? "Da" : "Ne";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value != null && value.ToString() == "Da";
        }

 
    }
}
