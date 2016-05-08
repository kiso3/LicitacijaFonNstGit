using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfInterface3.Panel.Ucesnik
{
    class TFTelefon : UserControl
    {
        Label lblTelefon;
        public TextBox txtTelefon;
        Grid gridBase;
        public TFTelefon()
        {
            kreirajKomoponentu();
            postaviKomponentu();
            this.Content = gridBase;
        }

        void kreirajKomoponentu()
        {
            this.gridBase = new Grid();
            this.lblTelefon = new Label() { Content = "Telefon:" };
            this.txtTelefon = new TextBox() { IsEnabled = true, Text = "" };
        }

        void postaviKomponentu()
        {

            this.txtTelefon.Margin = new Thickness(2);

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

            gridBase.Children.Add(lblTelefon);
            gridBase.Children.Add(txtTelefon);
            Grid.SetColumn(lblTelefon, 0);
            Grid.SetRow(lblTelefon, 0);
            Grid.SetColumn(txtTelefon, 1);
            Grid.SetRow(txtTelefon, 0);
        }
    }
}
