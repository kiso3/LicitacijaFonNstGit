using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfInterface3.Panel.PrijavaPanel
{
    class RBtnObilazakZemlj : UserControl
    {
        public RadioButton RBtnObisaoZelj;
        public RadioButton RBtnNisamObisaoZelj;
        
        Grid gridBase;
        public RBtnObilazakZemlj()
        {
            kreirajKomoponentu();
            postaviKomponentu();
            Content = gridBase;
        }

        void kreirajKomoponentu()
        {
            gridBase = new Grid();
            RBtnObisaoZelj = new RadioButton() {
               // GroupName = "ObilazakZemljista",
                Content = "Obišao/la sam zemljište za koje se prijavljujem na nadmetanje"
            };
            RBtnNisamObisaoZelj = new RadioButton() {
                //GroupName = "ObilazakZemljista",
                Content = "Nisam obišao/la zemljište za koje se prijavljujem na nadmetanje, iako mi je pružena prilika za to"
            }; 
        }

        void postaviKomponentu()
        {

            //this.txtPib.Margin = new Thickness(2);

            gridBase.ColumnDefinitions.Add(new ColumnDefinition()
            {
                Width = GridLength.Auto,
                MinWidth = 80                
            });
            gridBase.RowDefinitions.Add(new RowDefinition()
            {
                Height = GridLength.Auto

            });

            gridBase.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Auto, MaxHeight = 24 });

            gridBase.Children.Add(RBtnObisaoZelj);
            gridBase.Children.Add(RBtnNisamObisaoZelj);
            Grid.SetColumn(RBtnObisaoZelj, 0);
            Grid.SetRow(RBtnObisaoZelj, 0);
            Grid.SetColumn(RBtnNisamObisaoZelj, 0);
            Grid.SetRow(RBtnNisamObisaoZelj, 1);
        }

    }
}
