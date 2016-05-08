using DomenskeKlase.Licitacija;
using System.Windows;
using System.Windows.Controls;
using WpfInterface3.Director;
using WpfInterface3.Director.PrijavaBuilder;
using WpfInterface3.Form;
using WpfInterface3.Panel;
using WpfInterface3.PanelForm.NadmetanjePanelForm;

namespace WpfInterface3.FormKontrole.NadmetanjeFromKontole
{
    class BtnTablePrijavaIzmeni : DecoratorForm
    {
        public ButtonPanel buttonPanel;
        public LblRezultatOperacije lblRezultatOperacije;
        public BtnTablePrijavaIzmeni(UnosForm unosForm) : base(unosForm)
        {
            this.buttonPanel = new ButtonPanel("Izmeni");
            lblRezultatOperacije = new LblRezultatOperacije();
            buttonPanel.Margin = new Thickness(2);
            lblRezultatOperacije.Margin = new Thickness(2);
        }

        public override void SetControler()
        {
            base.SetControler();

            //new TablePrijavaIzmeniKontroler(this);

            
            PrijaveZaNadmetanjePanelForm prijaveZaNadmetanjePanelForm = this.panelForm as PrijaveZaNadmetanjePanelForm;


            buttonPanel.btn.Click += delegate (object sender, RoutedEventArgs e)
            {
                Prijava prijava = (Prijava)prijaveZaNadmetanjePanelForm.TblPrijave.baseDataGrid.SelectedItem;

                if (prijava != null)
                {

                    if (prijava is PrijavaFizicko)
                    {
                        PrijavaFizickoBuilderFormIzmeni prijavaFizickoBuilderIzmeni = new PrijavaFizickoBuilderFormIzmeni(prijava as PrijavaFizicko);
                        DirectorForm directorForm = new DirectorForm(prijavaFizickoBuilderIzmeni);
                        KoordinatorForm.vratiKoordinatorForm().postaviFormu(directorForm.Konstrujisi());
                    }
                    else
                    {
                        PrijevaPravnoBulderFormIzmeni prijevaPravnoBulderFormIzmeni = new PrijevaPravnoBulderFormIzmeni(prijava as PrijavaPravno);
                        DirectorForm directorForm = new DirectorForm(prijevaPravnoBulderFormIzmeni);
                        KoordinatorForm.vratiKoordinatorForm().postaviFormu(directorForm.Konstrujisi());

                    }
                }
            };


        }
        public override void SetPanel()
        {
            base.SetPanel();            
            if (unosForm.panelForm is PrijaveZaNadmetanjePanelForm)
            {

                PrijaveZaNadmetanjePanelForm prijaveZaNadmetanjePanelForm = unosForm.panelForm as PrijaveZaNadmetanjePanelForm;

                prijaveZaNadmetanjePanelForm.gridBase.Children.Add(buttonPanel);
                Grid.SetColumn(buttonPanel, 1);
                Grid.SetRow(buttonPanel, 4);

                prijaveZaNadmetanjePanelForm.gridBase.Children.Add(lblRezultatOperacije);
                Grid.SetColumn(lblRezultatOperacije, 1);
                Grid.SetRow(lblRezultatOperacije, 5);
            }

        }        
    }
}
