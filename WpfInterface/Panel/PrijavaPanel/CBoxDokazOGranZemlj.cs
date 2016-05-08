using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfInterface3.Panel.PrijavaPanel
{
    class CBoxDokazOGranZemlj : UserControl
    {

        public CheckBox cboxDokazOVlasnistvu;
        Grid gridBase;
        public CBoxDokazOGranZemlj()
        {
            kreirajKomoponentu();
            postaviKomponentu();
            Content = gridBase;
        }

        void kreirajKomoponentu()
        {
            gridBase = new Grid();

            cboxDokazOVlasnistvu = new CheckBox() { IsEnabled = true, Content = "Dokaz o vlasništvu poljoprivrednog zemljišta koje se graniči sa zemljištem koje se predmet zakupa" };
        }

        void postaviKomponentu()
        {

            cboxDokazOVlasnistvu.Margin = new Thickness(2);

            gridBase.ColumnDefinitions.Add(new ColumnDefinition()
            {
                Width = GridLength.Auto,
                MinWidth = 80
                //MaxWidth = 500
            });

            gridBase.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Auto, MaxHeight = 24 });

            gridBase.Children.Add(cboxDokazOVlasnistvu);

            Grid.SetColumn(cboxDokazOVlasnistvu, 0);
            Grid.SetRow(cboxDokazOVlasnistvu, 0);
        }
    }
}
