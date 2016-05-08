using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfInterface3.Panel.NadmetanjePanel
{
    class ComboBoxNadmetanjeZaGodinu : UserControl
    {
        Label lblNadmetanjeZaGodinu;
        public ComboBox cboxNadmetanjeZaGodinu;
        Grid gridBase;
        public ComboBoxNadmetanjeZaGodinu()
        {
            kreirajKomoponentu();
            postaviKomponentu();
            this.Content = gridBase;
        }

        void kreirajKomoponentu()
        {
            this.gridBase = new Grid();
            this.lblNadmetanjeZaGodinu = new Label() { Content = "Nadmetanje za godinu:" };
            this.cboxNadmetanjeZaGodinu = new ComboBox() { IsEnabled = true, SelectedValuePath = "Oglas.DatumObjave", DisplayMemberPath = "Oglas.DatumObjave" };
            cboxNadmetanjeZaGodinu.ItemStringFormat = "yyyy";
        }

        void postaviKomponentu()
        {

            this.cboxNadmetanjeZaGodinu.Margin = new Thickness(2);

            gridBase.ColumnDefinitions.Add(new ColumnDefinition()
            {
                Width = GridLength.Auto,
                MinWidth = 100,
                MaxWidth = 300
            });
            gridBase.ColumnDefinitions.Add(new ColumnDefinition()
            {
                Width = GridLength.Auto,
                MinWidth = 100,
                MaxWidth = 300

            });

            gridBase.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Auto, MaxHeight = 24 });

            gridBase.Children.Add(lblNadmetanjeZaGodinu);
            gridBase.Children.Add(cboxNadmetanjeZaGodinu);
            Grid.SetColumn(lblNadmetanjeZaGodinu, 0);
            Grid.SetRow(lblNadmetanjeZaGodinu, 0);
            Grid.SetColumn(cboxNadmetanjeZaGodinu, 1);
            Grid.SetRow(cboxNadmetanjeZaGodinu, 0);
        }


    }
}
