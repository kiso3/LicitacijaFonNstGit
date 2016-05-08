using System.Windows;
using System.Windows.Controls;
using WpfInterface3.Director;
using WpfInterface3.Director.Ucesnik;
using WpfInterface3.Form;
using WpfInterface3.Panel;
using WpfInterface3.PanelForm.Ucesnik;

namespace WpfInterface3.FormKontrole.Ucesnik
{
    class BtnTableLiceDodaj : DecoratorForm
    {
        public ButtonPanel buttonPanel;
        public LblRezultatOperacije lblRezultatOperacije;

        public BtnTableLiceDodaj(UnosForm unosForm) : base(unosForm)
        {
            buttonPanel = new ButtonPanel("Dodaj");
            lblRezultatOperacije = new LblRezultatOperacije();
            buttonPanel.Margin = new Thickness(2);
            lblRezultatOperacije.Margin = new Thickness(2);
        }

        public override void SetControler()
        {
            base.SetControler();
            //new KontrolerBtnTableLiceDoadj(this);
            

            buttonPanel.btn.Click += delegate (object sender, RoutedEventArgs e)
            {
                FizickoBuilderFormDodaj fizickoFormDodaj = new FizickoBuilderFormDodaj();
                DirectorForm directorForm = new DirectorForm(fizickoFormDodaj);
                KoordinatorForm.vratiKoordinatorForm().postaviFormu(directorForm.Konstrujisi());
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
