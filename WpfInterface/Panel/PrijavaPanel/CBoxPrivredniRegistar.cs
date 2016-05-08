using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfInterface3.Panel.PrijavaPanel
{
    class CBoxPrivredniRegistar : UserControl
    {
        public CheckBox cboxDokazOVlasnistvu;
        Grid gridBase;
        public CBoxPrivredniRegistar()
        {
            kreirajKomoponentu();
            postaviKomponentu();
            Content = gridBase;
        }

        void kreirajKomoponentu()
        {
            gridBase = new Grid();

            cboxDokazOVlasnistvu = new CheckBox() { IsEnabled = true, Content = "Izvod iz privrednog registra" };
        }

        void postaviKomponentu()
        {

            cboxDokazOVlasnistvu.Margin = new Thickness(2);

            gridBase.ColumnDefinitions.Add(new ColumnDefinition()
            {
                Width = GridLength.Auto,
                MinWidth = 80,
                MaxWidth = 300
            });

            gridBase.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Auto, MaxHeight = 24 });

            gridBase.Children.Add(cboxDokazOVlasnistvu);

            Grid.SetColumn(cboxDokazOVlasnistvu, 0);
            Grid.SetRow(cboxDokazOVlasnistvu, 0);
        }
    }
}
