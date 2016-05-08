using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfInterface3.Panel.NadmetanjePanel
{
    class TFNadmetanjeOznaka : UserControl
    {
        Label lblNadmetajeOznaka;
        public TextBox txtNadmetajeOznaka;
        Grid gridBase;
        public TFNadmetanjeOznaka()
        {
            kreirajKomoponentu();
            postaviKomponentu();
            Content = gridBase;
        }

        void kreirajKomoponentu()
        {
            gridBase = new Grid();
            lblNadmetajeOznaka = new Label() { Content = "Nadmetanje:" };
            txtNadmetajeOznaka = new TextBox() { IsEnabled = true, Text = "" };
        }

        void postaviKomponentu()
        {

            txtNadmetajeOznaka.Margin = new Thickness(2);

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

            gridBase.Children.Add(lblNadmetajeOznaka);
            gridBase.Children.Add(txtNadmetajeOznaka);
            Grid.SetColumn(lblNadmetajeOznaka, 0);
            Grid.SetRow(lblNadmetajeOznaka, 0);
            Grid.SetColumn(txtNadmetajeOznaka, 1);
            Grid.SetRow(txtNadmetajeOznaka, 0);
        }

    }
}
