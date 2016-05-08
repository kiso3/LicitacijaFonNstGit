using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfInterface3.Panel.Ucesnik
{
    class TFJmbg : UserControl
    {
        Label lblJmbg;
        public TextBox txtJmbg;
        Grid gridBase;
        public TFJmbg()
        {
            kreirajKomoponentu();
            postaviKomponentu();
            this.Content = gridBase;
        }

        void kreirajKomoponentu()
        {
            this.gridBase = new Grid();
            this.lblJmbg = new Label() { Content = "JMBG:" };
            this.txtJmbg = new TextBox() { IsEnabled = true, Text = "" };
        }

        void postaviKomponentu()
        {

            this.txtJmbg.Margin = new Thickness(2);

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

            gridBase.Children.Add(lblJmbg);
            gridBase.Children.Add(txtJmbg);
            Grid.SetColumn(lblJmbg, 0);
            Grid.SetRow(lblJmbg, 0);
            Grid.SetColumn(txtJmbg, 1);
            Grid.SetRow(txtJmbg, 0);
        }
    }
}
