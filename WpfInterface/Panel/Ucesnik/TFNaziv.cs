using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfInterface3.Panel.Ucesnik
{
    class TFNaziv : UserControl
    {
        Label lblNaziv;
        public TextBox txtNaziv;
        Grid gridBase;
        public TFNaziv()
        {
            kreirajKomoponentu();
            postaviKomponentu();
            this.Content = gridBase;
        }

        void kreirajKomoponentu()
        {
            this.gridBase = new Grid();
            this.lblNaziv = new Label() { Content = "Naziv:" };
            this.txtNaziv = new TextBox() { IsEnabled = true, Text = "" };
        }

        void postaviKomponentu()
        {

            this.txtNaziv.Margin = new Thickness(2);

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

            gridBase.Children.Add(lblNaziv);
            gridBase.Children.Add(txtNaziv);
            Grid.SetColumn(lblNaziv, 0);
            Grid.SetRow(lblNaziv, 0);
            Grid.SetColumn(txtNaziv, 1);
            Grid.SetRow(txtNaziv, 0);
        }
    }
}
