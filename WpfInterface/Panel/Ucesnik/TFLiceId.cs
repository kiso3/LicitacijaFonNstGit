using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfInterface3.Panel.Ucesnik
{
    class TFLiceId : UserControl
    {
        Label lblLiceId;
        public TextBox txtLiceId;
        Grid gridBase;
        public TFLiceId()
        {
            kreirajKomoponentu();
            postaviKomponentu();
            this.Content = gridBase;            
        }

        void kreirajKomoponentu()
        {
            this.gridBase = new Grid();
            this.lblLiceId = new Label() { Content = "Lice ID:" };
            this.txtLiceId = new TextBox() { IsEnabled = false, Text = "" };
        }

        void postaviKomponentu()
        {

            this.txtLiceId.Margin = new Thickness(2);

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

            gridBase.Children.Add(lblLiceId);
            gridBase.Children.Add(txtLiceId);
            Grid.SetColumn(lblLiceId, 0);
            Grid.SetRow(lblLiceId, 0);
            Grid.SetColumn(txtLiceId, 1);
            Grid.SetRow(txtLiceId, 0);
        }
    }
}
