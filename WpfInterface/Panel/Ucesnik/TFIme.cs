using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfInterface3.Panel.Ucesnik
{
    class TFIme : UserControl
    {
        Label lblIme;
        public TextBox txtIme;
        Grid gridBase;
        public TFIme()
        {            
            kreirajKomoponentu();
            postaviKomponentu();
            this.Content = gridBase;
        }

        void kreirajKomoponentu()
        {            
            this.gridBase = new Grid();           
            this.lblIme = new Label() { Content = "Ime:" };
            this.txtIme = new TextBox() { IsEnabled = true, Text = "" };
        }

        void postaviKomponentu()
        {

            this.txtIme.Margin = new Thickness(2);

            gridBase.ColumnDefinitions.Add(new ColumnDefinition()
            {
                Width = GridLength.Auto,
                MinWidth = 80,
                MaxWidth = 300
            });
            gridBase.ColumnDefinitions.Add(new ColumnDefinition()
            {
                Width = GridLength.Auto,
                MinWidth = 150,
                MaxWidth = 300

            });

            gridBase.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Auto, MaxHeight = 24 });

            gridBase.Children.Add(lblIme);
            gridBase.Children.Add(txtIme);
            Grid.SetColumn(lblIme, 0);
            Grid.SetRow(lblIme, 0);
            Grid.SetColumn(txtIme, 1);
            Grid.SetRow(txtIme, 0);
        }


    }
}
