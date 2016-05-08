using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfInterface3.Panel.NadmetanjePanel
{
    class TFMaxPovZakupa : UserControl
    {
        Label lblMaxPovZakupa;
        public TextBox txtMaxPovZakupa;
        Grid gridBase;
        public TFMaxPovZakupa()
        {
            kreirajKomoponentu();
            postaviKomponentu();
            Content = gridBase;
        }

        void kreirajKomoponentu()
        {
            gridBase = new Grid();
            lblMaxPovZakupa = new Label() { Content = "Max površina zakupa:" };
            txtMaxPovZakupa = new TextBox() { IsEnabled = true, Text = "" };
        }

        void postaviKomponentu()
        {

            txtMaxPovZakupa.Margin = new Thickness(2);

            gridBase.ColumnDefinitions.Add(new ColumnDefinition()
            {
                Width = GridLength.Auto,
                MinWidth = 130,
                MaxWidth = 300
            });
            gridBase.ColumnDefinitions.Add(new ColumnDefinition()
            {
                Width = GridLength.Auto,
                MinWidth = 150,
                MaxWidth = 300

            });

            gridBase.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Auto, MaxHeight = 24 });

            gridBase.Children.Add(lblMaxPovZakupa);
            gridBase.Children.Add(txtMaxPovZakupa);
            Grid.SetColumn(lblMaxPovZakupa, 0);
            Grid.SetRow(lblMaxPovZakupa, 0);
            Grid.SetColumn(txtMaxPovZakupa, 1);
            Grid.SetRow(txtMaxPovZakupa, 0);
        }

    }
}
