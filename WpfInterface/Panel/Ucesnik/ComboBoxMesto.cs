using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfInterface3.Panel.Ucesnik
{
    class ComboBoxMesto : UserControl
    {
        Label lblMesto;
        public ComboBox cboxMesto;
        Grid gridBase;
        public ComboBoxMesto()
        {
            kreirajKomoponentu();
            postaviKomponentu();
            this.Content = gridBase;
        }

        void kreirajKomoponentu()
        {
            this.gridBase = new Grid();
            this.lblMesto = new Label() { Content = "Mesto:" };
            this.cboxMesto = new ComboBox() { IsEnabled = true, SelectedValuePath = "Naziv", DisplayMemberPath = "Naziv" };
        }

        void postaviKomponentu()
        {

            this.cboxMesto.Margin = new Thickness(2);

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

            gridBase.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Auto, MaxHeight = 30 });

            gridBase.Children.Add(lblMesto);
            gridBase.Children.Add(cboxMesto);
            Grid.SetColumn(lblMesto, 0);
            Grid.SetRow(lblMesto, 0);
            Grid.SetColumn(cboxMesto, 1);
            Grid.SetRow(cboxMesto, 0);
        }

        
    }
}
