using System.Windows;
using System.Windows.Controls;
using WpfInterface3.Form;
using WpfInterface3.Panel;
using WpfInterface3.PanelForm.NadmetanjePanelForm;
using WpfInterface3.Form.Ucesnik;
using WpfInterface3.PanelForm.PrijavaPanelForm;

namespace WpfInterface3.FormKontrole.NadmetanjeFromKontole
{
    class BtnTableOdabirPonudjacaDodaj : DecoratorForm
    {
        public ButtonPanel buttonPanel;
        public LblRezultatOperacije lblRezultatOperacije;
        public BtnTableOdabirPonudjacaDodaj(UnosForm unosForm) : base(unosForm)
        {
            this.buttonPanel = new ButtonPanel("Dodaj");
            lblRezultatOperacije = new LblRezultatOperacije();
            buttonPanel.Margin = new Thickness(2);
            lblRezultatOperacije.Margin = new Thickness(2);
        }

        public override void SetControler()
        {
            base.SetControler();

            //new KontrolerBtnTableOdabirPonudjaca(this);
            
            PrijaveZaNadmetanjePanelForm prijaveZaNadmetanjePanelForm = this.panelForm as PrijaveZaNadmetanjePanelForm;

            buttonPanel.btn.Click += delegate (object sender, RoutedEventArgs e)
            {
                //prijaveZaNadmetanjePanelForm.Nadmetanje.Oglas.Resenje = null;
                prijaveZaNadmetanjePanelForm.Nadmetanje.PrijavaList = null;

                LicePrijavaPanelFormTabela licePrijavaPanelFormbela = new LicePrijavaPanelFormTabela(prijaveZaNadmetanjePanelForm.Nadmetanje);
                UnosForm licePrijavaFormTable =
                        new BtnOdaberipPoudjacaZaPrijavuNazad(
                            new BtnTablePrijavaDodaj(
                                new LicePrijavaFormTable(licePrijavaPanelFormbela)
                                ));

                licePrijavaFormTable.SetPanel();
                licePrijavaFormTable.SetControler();


                KoordinatorForm.vratiKoordinatorForm().postaviFormu(licePrijavaPanelFormbela);
            };

        }
        public override void SetPanel()
        {
            base.SetPanel();
            if (unosForm.panelForm is PrijaveZaNadmetanjePanelForm)
            {

                PrijaveZaNadmetanjePanelForm prijaveZaNadmetanjePanelForm = unosForm.panelForm as PrijaveZaNadmetanjePanelForm;

                prijaveZaNadmetanjePanelForm.gridBase.Children.Add(buttonPanel);
                Grid.SetColumn(buttonPanel, 0);
                Grid.SetRow(buttonPanel, 4);

                prijaveZaNadmetanjePanelForm.gridBase.Children.Add(lblRezultatOperacije);
                Grid.SetColumn(lblRezultatOperacije, 0);
                Grid.SetRow(lblRezultatOperacije, 5);
            }

        }        
    }
}
