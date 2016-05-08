using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfInterface3.Panel.PrijavaPanel
{
    class CBoxResenjePio : UserControl
    {

        public CheckBox cboxResenjePio;
        Grid gridBase;
        public CBoxResenjePio()
        {
            kreirajKomoponentu();
            postaviKomponentu();
            Content = gridBase;
        }

        void kreirajKomoponentu()
        {
            gridBase = new Grid();

            cboxResenjePio = new CheckBox() { IsEnabled = true, Content = "Važeće rešenje Republičkog fonda PIO o svojstvu osiguranika poljoprivrednika" };
        }

        void postaviKomponentu()
        {

            cboxResenjePio.Margin = new Thickness(2);

            gridBase.ColumnDefinitions.Add(new ColumnDefinition()
            {
                Width = GridLength.Auto,
                MinWidth = 80,
                MaxWidth = 400
            });

            gridBase.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Auto, MaxHeight = 24 });

            gridBase.Children.Add(cboxResenjePio);

            Grid.SetColumn(cboxResenjePio, 0);
            Grid.SetRow(cboxResenjePio, 0);
        }


    }
}
