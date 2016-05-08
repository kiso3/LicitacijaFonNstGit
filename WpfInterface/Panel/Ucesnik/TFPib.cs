using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfInterface3.Panel.Ucesnik
{
    class TFPib : UserControl
    {
        Label lblPib;
        public TextBox txtPib;
        Grid gridBase;
        public TFPib()
        {
            kreirajKomoponentu();
            postaviKomponentu();
            this.Content = gridBase;
        }

        void kreirajKomoponentu()
        {
            this.gridBase = new Grid();
            this.lblPib = new Label() { Content = "PIB:" };
            this.txtPib = new TextBox() { IsEnabled = true, Text = "" };
        }

        void postaviKomponentu()
        {

            this.txtPib.Margin = new Thickness(2);

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

            gridBase.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Auto, });

            gridBase.Children.Add(lblPib);
            gridBase.Children.Add(txtPib);
            Grid.SetColumn(lblPib, 0);
            Grid.SetRow(lblPib, 0);
            Grid.SetColumn(txtPib, 1);
            Grid.SetRow(txtPib, 0);
        }
    }
}
