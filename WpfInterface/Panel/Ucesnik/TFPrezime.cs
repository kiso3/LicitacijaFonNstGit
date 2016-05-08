using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfInterface3.Panel.Ucesnik
{
    class TFPrezime : UserControl
    {
        Label lblPrezime;
        public TextBox txtPrezime;
        Grid gridBase;
        public TFPrezime()
        {
            kreirajKomoponentu();
            postaviKomponentu();
            this.Content = gridBase;
        }

        void kreirajKomoponentu()
        {
            this.gridBase = new Grid();
            this.lblPrezime = new Label() { Content = "Prezime:" };
            this.txtPrezime = new TextBox() { IsEnabled = true, Text = "" };
        }

        void postaviKomponentu()
        {

            this.txtPrezime.Margin = new Thickness(2);

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

            gridBase.Children.Add(lblPrezime);
            gridBase.Children.Add(txtPrezime);
            Grid.SetColumn(lblPrezime, 0);
            Grid.SetRow(lblPrezime, 0);
            Grid.SetColumn(txtPrezime, 1);
            Grid.SetRow(txtPrezime, 0);
        }

    }
}
