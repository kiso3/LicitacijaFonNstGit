using DomenskeKlase.Licitacija;
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
    class KonverterPrijavaImePrezimeNaziv : IMultiValueConverter
    {

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
        
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (values[0] is PrijavaPravno)
            {
                PrijavaPravno data = values[0] as PrijavaPravno;
                return String.Format("{0}", data.Pravno.Naziv);
            }
            if(values[0] is PrijavaFizicko)
            {
                PrijavaFizicko data = values[0] as PrijavaFizicko;
                return String.Format("{0} {1}", data.Fizicko.Ime, data.Fizicko.Prezime);
            }
            return null;
        }
        
    }
}
