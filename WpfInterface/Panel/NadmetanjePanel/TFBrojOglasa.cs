using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfInterface3.Panel.NadmetanjePanel
{
    class TFBrojOglasa : UserControl
    {

        Label lblTBBrojOglasa;
        public TextBox txtBrojOglasa;
        Grid gridBase;
        public TFBrojOglasa()
        {
            kreirajKomoponentu();
            postaviKomponentu();
            Content = gridBase;
        }

        void kreirajKomoponentu()
        {
            gridBase = new Grid();
            lblTBBrojOglasa = new Label() { Content = "Broj oglasa:" };
            txtBrojOglasa = new TextBox() { IsEnabled = true, Text = "" };
        }

        void postaviKomponentu()
        {

            txtBrojOglasa.Margin = new Thickness(2);

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

            gridBase.Children.Add(lblTBBrojOglasa);
            gridBase.Children.Add(txtBrojOglasa);
            Grid.SetColumn(lblTBBrojOglasa, 0);
            Grid.SetRow(lblTBBrojOglasa, 0);
            Grid.SetColumn(txtBrojOglasa, 1);
            Grid.SetRow(txtBrojOglasa, 0);
        }


    }
}
