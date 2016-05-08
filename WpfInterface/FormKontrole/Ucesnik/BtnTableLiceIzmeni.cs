using DomenskeKlase.Ucenik;
using System.Windows;
using System.Windows.Controls;
using WpfInterface3.Director;
using WpfInterface3.Director.Ucesnik;
using WpfInterface3.Form;
using WpfInterface3.Panel;
using WpfInterface3.PanelForm.Ucesnik;

namespace WpfInterface3.FormKontrole.Ucesnik
{
    class BtnTableLiceIzmeni : DecoratorForm
    {
        public ButtonPanel buttonPanel;
        public LblRezultatOperacije lblRezultatOperacije;

        public BtnTableLiceIzmeni(UnosForm unosForm) : base(unosForm)
        {
            this.buttonPanel = new ButtonPanel("Izmeni");
            lblRezultatOperacije = new LblRezultatOperacije();
            buttonPanel.Margin = new Thickness(2);
            lblRezultatOperacije.Margin = new Thickness(2);
        }

        public override void SetControler()
        {
            base.SetControler();
            //new KontrolerBtnTableLiceIzmeni(this);           

            
            LicePanelFormTabela licePanelFormTabela = panelForm as LicePanelFormTabela;


            buttonPanel.btn.Click += delegate (object sender, RoutedEventArgs e)
            {
                Lice lice = (Lice)licePanelFormTabela.tblLice.baseDataGrid.SelectedItem;

                if (lice != null)
                {
                    if (lice is Fizicko)
                    {
                        FizickoBuilderFormIzmeni fizickoBuilderFormIzmeni = new FizickoBuilderFormIzmeni(lice as Fizicko);
                        DirectorForm directorForm = new DirectorForm(fizickoBuilderFormIzmeni);
                        KoordinatorForm.vratiKoordinatorForm().postaviFormu(directorForm.Konstrujisi());
                    }
                    else
                    {
                        PravnoBuilderFormIzmeni pravnoFormDodaj = new PravnoBuilderFormIzmeni(lice as Pravno);
                        DirectorForm directorForm = new DirectorForm(pravnoFormDodaj);
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
                Grid.SetColumn(buttonPanel, 1);
                Grid.SetRow(buttonPanel, 2);

                licePanelFormTabela.gridBase.Children.Add(lblRezultatOperacije);
                Grid.SetColumn(lblRezultatOperacije, 1);
                Grid.SetRow(lblRezultatOperacije, 3);
            }

        }
        
               
    }
}
