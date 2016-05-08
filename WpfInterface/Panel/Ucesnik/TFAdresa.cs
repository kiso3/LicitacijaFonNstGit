using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfInterface3.Panel.Ucesnik
{
    class TFAdresa : UserControl
    {
        Label lblAdresa;
        public TextBox txtAdresa;
        Grid gridBase;
        public TFAdresa()
        {
            kreirajKomoponentu();
            postaviKomponentu();
            this.Content = gridBase;
        }

        void kreirajKomoponentu()
        {
            this.gridBase = new Grid();
            this.lblAdresa = new Label() { Content = "Adresa:" };
            this.txtAdresa = new TextBox() { IsEnabled = true, Text = "" };
        }

        void postaviKomponentu()
        {

            this.txtAdresa.Margin = new Thickness(2);

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

            gridBase.Children.Add(lblAdresa);
            gridBase.Children.Add(txtAdresa);
            Grid.SetColumn(lblAdresa, 0);
            Grid.SetRow(lblAdresa, 0);
            Grid.SetColumn(txtAdresa, 1);
            Grid.SetRow(txtAdresa, 0);
        }
    }
}
