using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfInterface3.Panel.Ucesnik
{
    class TFMb : UserControl
    {
        Label lblMb;
        public TextBox txtMb;
        Grid gridBase;
        public TFMb()
        {
            kreirajKomoponentu();
            postaviKomponentu();
            this.Content = gridBase;
        }

        void kreirajKomoponentu()
        {
            this.gridBase = new Grid();
            this.lblMb = new Label() { Content = "MB:" };
            this.txtMb = new TextBox() { IsEnabled = true, Text = "" };
        }

        void postaviKomponentu()
        {

            this.txtMb.Margin = new Thickness(2);

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

            gridBase.Children.Add(lblMb);
            gridBase.Children.Add(txtMb);
            Grid.SetColumn(lblMb, 0);
            Grid.SetRow(lblMb, 0);
            Grid.SetColumn(txtMb, 1);
            Grid.SetRow(txtMb, 0);
        }


    }
}
