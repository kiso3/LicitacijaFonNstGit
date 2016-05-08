using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfInterface3.Panel.PrijavaPanel
{
    class CBoxRegPoljGazd : UserControl
    {
        
        public CheckBox cboxRegPoljGazd;
        Grid gridBase;
        public CBoxRegPoljGazd()
        {
            kreirajKomoponentu();
            postaviKomponentu();
            Content = gridBase;
        }

        void kreirajKomoponentu()
        {
            gridBase = new Grid();
            
            cboxRegPoljGazd = new CheckBox() { IsEnabled = true, Content = "Važeći izvod iz regista poljoprivrednix gazdinstva" };
        }

        void postaviKomponentu()
        {

            cboxRegPoljGazd.Margin = new Thickness(2);

            gridBase.ColumnDefinitions.Add(new ColumnDefinition()
            {
                Width = GridLength.Auto,
                MinWidth = 80,
                MaxWidth = 400
            });

            gridBase.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Auto, MaxHeight = 24 });
            
            gridBase.Children.Add(cboxRegPoljGazd);
               
            Grid.SetColumn(cboxRegPoljGazd, 0);
            Grid.SetRow(cboxRegPoljGazd, 0);
        }
    }
}
