using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfInterface3.Panel.NadmetanjePanel
{
    class TFDatumObjave : UserControl
    {

        Label lblDatumObjave;
        public TextBox txtDatumObjave;
        Grid gridBase;
        public TFDatumObjave()
        {
            kreirajKomoponentu();
            postaviKomponentu();
            this.Content = gridBase;
        }

        void kreirajKomoponentu()
        {
            this.gridBase = new Grid();
            this.lblDatumObjave = new Label() { Content = "Datum objave:" };
            this.txtDatumObjave = new TextBox() { IsEnabled = true, Text = "" };
        }

        void postaviKomponentu()
        {

            this.txtDatumObjave.Margin = new Thickness(0);

            gridBase.ColumnDefinitions.Add(new ColumnDefinition()
            {
                Width = GridLength.Auto,
                MinWidth = 130,
                MaxWidth = 300
            });
            gridBase.ColumnDefinitions.Add(new ColumnDefinition()
            {
                Width = GridLength.Auto,
                MinWidth = 150,
                MaxWidth = 300                       
            });

            gridBase.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Auto, MaxHeight = 24 });

            gridBase.Children.Add(lblDatumObjave);
            gridBase.Children.Add(txtDatumObjave);
            Grid.SetColumn(lblDatumObjave, 0);
            Grid.SetRow(lblDatumObjave, 0);
            Grid.SetColumn(txtDatumObjave, 1);
            Grid.SetRow(txtDatumObjave, 0);
        }
    }
}
