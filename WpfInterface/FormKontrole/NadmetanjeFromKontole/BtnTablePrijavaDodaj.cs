using DomenskeKlase.Licitacija;
using DomenskeKlase.Ucenik;
using System.Windows;
using System.Windows.Controls;
using WpfInterface3.Director;
using WpfInterface3.Director.PrijavaBuilder;
using WpfInterface3.Form;
using WpfInterface3.Panel;
using WpfInterface3.PanelForm.PrijavaPanelForm;
using WpfInterface3.PanelForm.Ucesnik;

namespace WpfInterface3.FormKontrole.NadmetanjeFromKontole
{
    class BtnTablePrijavaDodaj : DecoratorForm
    {
        public ButtonPanel buttonPanel;
        public LblRezultatOperacije lblRezultatOperacije;
        public BtnTablePrijavaDodaj(UnosForm unosForm) : base(unosForm)
        {
            this.buttonPanel = new ButtonPanel("Odaberi");
            lblRezultatOperacije = new LblRezultatOperacije();
            buttonPanel.Margin = new Thickness(2);
            lblRezultatOperacije.Margin = new Thickness(2);
        }

        public override void SetControler()
        {
            base.SetControler();

            //new KontrolerBtnTablePrijavaDodaj(this);
                        
            LicePrijavaPanelFormTabela _licePrijavaPanelFormTabela = this.panelForm as LicePrijavaPanelFormTabela;

            buttonPanel.btn.Click += delegate (object sender, RoutedEventArgs e)
            {
                Lice lice = (Lice)_licePrijavaPanelFormTabela.tblLice.baseDataGrid.SelectedItem;

                if (lice != null)
                {
                    if (lice is Fizicko)
                    {
                        PrijavaFizicko prijavaFizicko = new PrijavaFizicko();
                        prijavaFizicko.Fizicko = lice as Fizicko;
                        prijavaFizicko.Nadmetanje = _licePrijavaPanelFormTabela.Nadmetanje;

                        PrijavaFizickoBuilderFormDodaj prijavaFizickoBuilderFormDodaj = new PrijavaFizickoBuilderFormDodaj(prijavaFizicko);
                        DirectorForm directorForm = new DirectorForm(prijavaFizickoBuilderFormDodaj);
                        KoordinatorForm.vratiKoordinatorForm().postaviFormu(directorForm.Konstrujisi());
                    }
                    else
                    {


                        PrijavaPravno prijavaPravno = new PrijavaPravno();
                        prijavaPravno.Pravno = lice as Pravno;
                        prijavaPravno.Nadmetanje = _licePrijavaPanelFormTabela.Nadmetanje;

                        PrijavaPravnoBuilderFormDodaj prijavaPravnoBuilderFormDodaj = new PrijavaPravnoBuilderFormDodaj(prijavaPravno);
                        DirectorForm directorForm = new DirectorForm(prijavaPravnoBuilderFormDodaj);
                        KoordinatorForm.vratiKoordinatorForm().postaviFormu(directorForm.Konstrujisi());



                    }
                }
            };

        }
        public override void SetPanel()
        {
            base.SetPanel();
            if (unosForm.panelForm is LicePanelFormTabela)
            {

                LicePanelFormTabela licePanelFormTabela = unosForm.panelForm as LicePanelFormTabela;

                licePanelFormTabela.gridBase.Children.Add(buttonPanel);
                Grid.SetColumn(buttonPanel, 0);
                Grid.SetRow(buttonPanel, 2);

                licePanelFormTabela.gridBase.Children.Add(lblRezultatOperacije);
                Grid.SetColumn(lblRezultatOperacije, 0);
                Grid.SetRow(lblRezultatOperacije, 3);
            }

        }       
    }
}
