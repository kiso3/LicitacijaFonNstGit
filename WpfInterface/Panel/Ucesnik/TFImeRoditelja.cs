using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfInterface3.Panel.Ucesnik
{
    class TFImeRoditelja : UserControl
    {
        Label lblImeRoditelja;
        public TextBox txtImeRoditelja;
        Grid gridBase;
        public TFImeRoditelja()
        {
            kreirajKomoponentu();
            postaviKomponentu();
            this.Content = gridBase;
        }

        void kreirajKomoponentu()
        {
            this.gridBase = new Grid();
            this.lblImeRoditelja = new Label() { Content = "Ime roditelja:" };
            this.txtImeRoditelja = new TextBox() { IsEnabled = true, Text = "" };
        }

        void postaviKomponentu()
        {

            this.txtImeRoditelja.Margin = new Thickness(2);

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

            gridBase.Children.Add(lblImeRoditelja);
            gridBase.Children.Add(txtImeRoditelja);
            Grid.SetColumn(lblImeRoditelja, 0);
            Grid.SetRow(lblImeRoditelja, 0);
            Grid.SetColumn(txtImeRoditelja, 1);
            Grid.SetRow(txtImeRoditelja, 0);
        }
    }
}
