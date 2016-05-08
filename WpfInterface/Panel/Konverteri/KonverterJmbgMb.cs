using DomenskeKlase.Ucenik;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WpfInterface3.Panel.TablePanel
{
    class KonverterJmbgMb : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values[0] is Pravno)
            {
                Pravno data = values[0] as Pravno;
                return String.Format("{0}", data.Mb);
            }
            if (values[0] is Fizicko)
            {
                Fizicko data = values[0] as Fizicko;
                return String.Format("{0}", data.Jmbg);
            }
            return null;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
