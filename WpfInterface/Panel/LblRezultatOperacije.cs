using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfInterface3.Panel
{
    class LblRezultatOperacije : UserControl
    {        
        public Label lblRezultatPoruka;
        Grid gridBase;
        public LblRezultatOperacije()
        {
            kreirajKomoponentu();
            postaviKomponentu();
            this.Content = gridBase;
        }

        void kreirajKomoponentu()
        {
            this.gridBase = new Grid();            
            this.lblRezultatPoruka = new Label() { Content = "" };
        }

        void postaviKomponentu()
        {

            this.lblRezultatPoruka.Margin = new Thickness(2);

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

            
            gridBase.Children.Add(lblRezultatPoruka);
            Grid.SetColumn(lblRezultatPoruka, 0);
            Grid.SetRow(lblRezultatPoruka, 0);
        }
    }
}
