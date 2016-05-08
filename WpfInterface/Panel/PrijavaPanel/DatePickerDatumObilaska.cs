using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfInterface3.Panel.PrijavaPanel
{
    class DatePickerDatumObilaska : UserControl
    {
        Label lblDatumObilaska;
        public DatePicker dpDatumObilaska;
        Grid gridBase;
        public DatePickerDatumObilaska()
        {
            kreirajKomoponentu();
            postaviKomponentu();
            Content = gridBase;
        }

        void kreirajKomoponentu()
        {
            gridBase = new Grid();
            lblDatumObilaska = new Label() { Content = "Datum obilaska:" };
            dpDatumObilaska = new DatePicker();
        }

        void postaviKomponentu()
        {

            dpDatumObilaska.Margin = new Thickness(2);

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

            gridBase.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Auto, MaxHeight = 30 });

            gridBase.Children.Add(lblDatumObilaska);
            gridBase.Children.Add(dpDatumObilaska);
            Grid.SetColumn(lblDatumObilaska, 0);
            Grid.SetRow(lblDatumObilaska, 0);
            Grid.SetColumn(dpDatumObilaska, 1);
            Grid.SetRow(dpDatumObilaska, 0);
        }
    }
}
