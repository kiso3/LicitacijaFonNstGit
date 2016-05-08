using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfInterface3.Panel
{
    class ButtonPanel : UserControl
    {

        public Button btn;
        Grid gridBase;

        public ButtonPanel(String content)
        {            
            kreirajKomoponentu(content);
            postaviKomponentu();
            this.Content = gridBase;
        }

        private void kreirajKomoponentu(String content)
        {
            this.gridBase = new Grid();
            this.btn = new Button() { Content = content };            
        }

        private void postaviKomponentu()
        {            

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

            gridBase.Children.Add(btn);            
            Grid.SetColumn(btn, 0);
            Grid.SetRow(btn, 0);            
        }
    
    }
}
