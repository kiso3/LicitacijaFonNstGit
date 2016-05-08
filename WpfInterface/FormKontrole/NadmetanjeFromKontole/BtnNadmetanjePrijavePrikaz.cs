using DomenskeKlase.LicitacijaPriprema;
using System.Windows;
using System.Windows.Controls;
using WpfInterface3.Director;
using WpfInterface3.Director.NadmetanjeDirector;
using WpfInterface3.Form;
using WpfInterface3.Panel;
using WpfInterface3.PanelForm.NadmetanjePanelForm;

namespace WpfInterface3.FormKontrole.NadmetanjeFormKontrole
{
    class BtnNadmetanjePrijavePrikaz: DecoratorForm
    {

        public ButtonPanel buttonPanel;
        public LblRezultatOperacije lblRezultatOperacije;
        public BtnNadmetanjePrijavePrikaz(UnosForm unosForm) : base(unosForm)
        {
            this.buttonPanel = new ButtonPanel("Prikaži");
            lblRezultatOperacije = new LblRezultatOperacije();
            buttonPanel.Margin = new Thickness(2);
            lblRezultatOperacije.Margin = new Thickness(2);
        }
        public override void SetControler()
        {
            base.SetControler();
            //new KontrolerBtnNadmetanjePrijavePrikaz(this);
            NadmetanjePanelForm nadmetanjePanelForm = this.panelForm as NadmetanjePanelForm;

            buttonPanel.btn.Click += delegate (object sender, RoutedEventArgs e)
            {
                Nadmetanje nadmetanje = (Nadmetanje)nadmetanjePanelForm.TblNadmetanje.baseDataGrid.SelectedItem;
                if (nadmetanje != null)
                {
                    nadmetanje.Oglas.Resenje = nadmetanjePanelForm.Resenje;
                    PrijaveZaNadmetanjeFormBuilder prijaveZaNadmetanjeFormBuilder = new PrijaveZaNadmetanjeFormBuilder(nadmetanje);
                    DirectorForm directorForm = new DirectorForm(prijaveZaNadmetanjeFormBuilder);
                    KoordinatorForm.vratiKoordinatorForm().postaviFormu(directorForm.Konstrujisi());
                }
            };
        }
        public override void SetPanel()
        {
            base.SetPanel();
            if (unosForm.panelForm is NadmetanjePanelForm)
            {
                NadmetanjePanelForm nadmetanjePanelForm = unosForm.panelForm as NadmetanjePanelForm;
                nadmetanjePanelForm.gridBase.Children.Add(buttonPanel);
                Grid.SetColumn(buttonPanel, 0);
                Grid.SetRow(buttonPanel, 4);

                nadmetanjePanelForm.gridBase.Children.Add(lblRezultatOperacije);
                Grid.SetColumn(lblRezultatOperacije, 1);
                Grid.SetRow(lblRezultatOperacije, 4);
            }

        }
        

    }
}
