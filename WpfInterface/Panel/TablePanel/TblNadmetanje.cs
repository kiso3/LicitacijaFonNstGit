using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows;

namespace WpfInterface3.Panel.TablePanel
{
    class TblNadmetanje : TabelarniPrikaz
    {
        public TblNadmetanje():base()
        {
            addColumn();
        }
        protected override void addColumn()
        {
            baseDataGrid.AutoGenerateColumns = false;
            DataGridTextColumn nadmetanjeId = new DataGridTextColumn()
            {
                Header = "NadmetanjeId",
                Binding = new Binding("NadmetanjeId"),
                Visibility = Visibility.Hidden
            };
            baseDataGrid.Columns.Add(nadmetanjeId);

            DataGridTextColumn pib = new DataGridTextColumn()
            {
                Header = "Oznaka",
                Binding = new Binding("OznakaNadmetanja"),
                Visibility = Visibility.Visible
            };
            baseDataGrid.Columns.Add(pib);

            DataGridTextColumn pocetnaCena = new DataGridTextColumn()
            {
                Header = "Počеtna cena",
                Binding = new Binding("PocetnaCena"),
                Visibility = Visibility.Visible
            };
            baseDataGrid.Columns.Add(pocetnaCena);

            DataGridTextColumn datumNadmetanja = new DataGridTextColumn()
            {
                Header = "Datum nadmetanja",
                Binding = new Binding("DatumNadmetanja") { StringFormat = "dd-MM-yyyy" },
                Visibility = Visibility.Visible
            };
            baseDataGrid.Columns.Add(datumNadmetanja);

            DataGridTextColumn depozit = new DataGridTextColumn()
            {
                Header = "Depozit",
                Binding = new Binding("Depozit"),
                Visibility = Visibility.Visible
            };
            baseDataGrid.Columns.Add(depozit);

            DataGridTextColumn periodZakupa = new DataGridTextColumn()
            {
                Header = "Period zakupa",
                Binding = new Binding("PeriodZakupa"),
                Visibility = Visibility.Visible
            };
            baseDataGrid.Columns.Add(periodZakupa);
        }
    }
}
