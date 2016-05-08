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
    class TblPrijave : TabelarniPrikaz
    {
        public TblPrijave():base()
        {
            addColumn();
        }
        protected override void addColumn()
        {
            baseDataGrid.AutoGenerateColumns = false;
            DataGridTextColumn prijavaId = new DataGridTextColumn()
            {
                Header = "Prijava ID",
                Binding = new Binding("PrijavaId"),
                Visibility = Visibility.Visible
            };
            baseDataGrid.Columns.Add(prijavaId);
            
            MultiBinding multiBindingImePrezime = new MultiBinding();
            multiBindingImePrezime.Converter = new KonverterPrijavaImePrezimeNaziv();
            multiBindingImePrezime.Bindings.Add(new Binding());
            multiBindingImePrezime.NotifyOnSourceUpdated = true;

            DataGridTextColumn naziv = new DataGridTextColumn()
            {
                Header = "Naziv lica",
                Binding = multiBindingImePrezime,
                Visibility = Visibility.Visible
            };
            baseDataGrid.Columns.Add(naziv);
            
            DataGridTextColumn datumPodnosenja = new DataGridTextColumn()
            {
                Header = "Datum Podnošenja",
                Binding = new Binding("Datumpodnosenja") { StringFormat="dd-MM-yyyy" },
                Visibility = Visibility.Visible
            };
            baseDataGrid.Columns.Add(datumPodnosenja);

            DataGridTextColumn resejePio = new DataGridTextColumn()
            {
                Header = "Rešemke PIO",
                Binding = new Binding("ResenjePio") { Converter = new KonverterDaNeBool() },
                Visibility = Visibility.Visible
            };
            baseDataGrid.Columns.Add(resejePio);

            DataGridTextColumn vlasnistvo = new DataGridTextColumn()
            {
                Header = "Vlasništvo",
                Binding = new Binding("DokazOVlasnistvu") { Converter = new KonverterDaNeBool() },
                Visibility = Visibility.Visible
            };
            baseDataGrid.Columns.Add(vlasnistvo);

            DataGridTextColumn regisarPoljGazd = new DataGridTextColumn()
            {
                Header = "Reg. Polj. Gazd.",
                Binding = new Binding("RegistarPoljGazd") { Converter = new KonverterDaNeBool() },
                Visibility = Visibility.Visible
            };
            baseDataGrid.Columns.Add(regisarPoljGazd);

            DataGridTextColumn upoznat = new DataGridTextColumn()
            {
                Header = "Upoznat",
                Binding = new Binding("UpoznatSaPonudom") { Converter = new KonverterDaNeBool()},
                Visibility = Visibility.Visible
            };
            baseDataGrid.Columns.Add(upoznat);


            DataGridTextColumn datumObilaska = new DataGridTextColumn()
            {
                Header = "Datum obilaska",
                Binding = new Binding("DatumObilaska") { StringFormat="dd-MM-yyyy" },
                Visibility = Visibility.Visible
            };
            baseDataGrid.Columns.Add(datumObilaska);


            DataGridTextColumn depozit = new DataGridTextColumn()
            {
                Header = "Depozit",
                Binding = new Binding("DokazOUplatiDepozita") { Converter = new KonverterDaNeBool() },
                Visibility = Visibility.Visible
            };
            baseDataGrid.Columns.Add(depozit);
        }
    }
}
