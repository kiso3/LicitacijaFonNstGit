using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfInterface3.Panel.Ucesnik
{
    class RadioLice : UserControl
    {
        public RadioButton radioFizicko;
        public RadioButton radioPravno;
        Grid gridBase;
        public RadioLice()
        {
            kreirajKomoponentu();
            postaviKomponentu();
            this.Content = gridBase;
        }

        void kreirajKomoponentu()
        {
            this.gridBase = new Grid();
            this.radioFizicko = new RadioButton() { Content = "Fizičko:" };
            this.radioPravno = new RadioButton() { Content = "Pravno:" }; ;
        }

        void postaviKomponentu()
        {

            //this.txtPib.Margin = new Thickness(2);

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

            gridBase.Children.Add(radioFizicko);
            gridBase.Children.Add(radioPravno);
            Grid.SetColumn(radioFizicko, 0);
            Grid.SetRow(radioFizicko, 0);
            Grid.SetColumn(radioPravno, 1);
            Grid.SetRow(radioPravno, 0);
        }
    }
}
