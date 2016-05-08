using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace WpfInterface3.Panel.TablePanel
{
    class TblLice : TabelarniPrikaz
    {
        public TblLice():base()
        {
           addColumn();
        }
        protected override void addColumn()
        {
            baseDataGrid.AutoGenerateColumns = false;
            DataGridTextColumn pib = new DataGridTextColumn()
            {
                Header = "PIB",
                Binding = new Binding("Pib"),
                Visibility = Visibility.Visible
            };
            baseDataGrid.Columns.Add(pib);


            MultiBinding multiBindingImePrezime = new MultiBinding();
            multiBindingImePrezime.Converter = new KonverterImePrezimeNaziv();
            multiBindingImePrezime.Bindings.Add(new Binding());
            multiBindingImePrezime.NotifyOnSourceUpdated = true;
            
            DataGridTextColumn naziv = new DataGridTextColumn()
            {
                Header = "Naziv lica",
                Binding = multiBindingImePrezime,
                Visibility = Visibility.Visible
            };
            baseDataGrid.Columns.Add(naziv);


            MultiBinding multiBindingJmbgMb = new MultiBinding();
            multiBindingJmbgMb.Converter = new KonverterJmbgMb();
            multiBindingJmbgMb.Bindings.Add(new Binding());
            multiBindingJmbgMb.NotifyOnSourceUpdated = true;

            DataGridTextColumn mbJmbg = new DataGridTextColumn()
            {
                Header = "MB/JMBG",
                Binding = multiBindingJmbgMb,
                Visibility = Visibility.Visible
            };
            
            baseDataGrid.Columns.Add(mbJmbg);

            DataGridTextColumn email = new DataGridTextColumn()
            {
                Header = "Email",
                Binding = new Binding("Email"),
                Visibility = Visibility.Visible
            };
            baseDataGrid.Columns.Add(email);


            DataGridTextColumn mesto = new DataGridTextColumn()
            {
                Header = "Mesto",
                Binding = new Binding("Mesto.Naziv"),
                Visibility = Visibility.Visible
            };
            baseDataGrid.Columns.Add(mesto);



            DataGridTextColumn telefon = new DataGridTextColumn()
            {
                Header = "Telefon",
                Binding = new Binding("Telefon"),
                Visibility = Visibility.Visible
            };
            baseDataGrid.Columns.Add(telefon);
        }
    }
}
