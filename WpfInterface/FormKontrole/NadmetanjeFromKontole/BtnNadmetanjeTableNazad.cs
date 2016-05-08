using DomenskeKlase.LicitacijaPriprema;
using System.Windows;
using System.Windows.Controls;
using WpfInterface3.Director;
using WpfInterface3.Director.NadmetanjeDirector;
using WpfInterface3.Form;
using WpfInterface3.Panel;
using WpfInterface3.PanelForm.NadmetanjePanelForm;

namespace WpfInterface3.FormKontrole.NadmetanjeFromKontole
{
    class BtnNadmetanjeTableNazad : DecoratorForm
    {
        public ButtonPanel buttonPanel;

        public BtnNadmetanjeTableNazad(UnosForm unosForm) : base(unosForm)
        {
            buttonPanel = new ButtonPanel("Nazad");
            buttonPanel.Margin = new Thickness(2);
        }

        public override void SetControler()
        {
            base.SetControler();

            //new KontrolerBtnNadmetanjeTableNazad(this);            
            PrijaveZaNadmetanjePanelForm prijaveZaNadmetanjePanelForm = this.panelForm as PrijaveZaNadmetanjePanelForm;

            buttonPanel.btn.Click += delegate (object sender, RoutedEventArgs e)
            {

                Resenje resenje = prijaveZaNadmetanjePanelForm.Nadmetanje.Oglas.Resenje;
                if (resenje != null)
                {
                    resenje.Oglas.NadmetanjeList = null;
                    NadmetanjeTableFormBuilderPrikaz prijaveZaNadmetanjeFormBuilder = new NadmetanjeTableFormBuilderPrikaz(resenje);
                    DirectorForm directorForm = new DirectorForm(prijaveZaNadmetanjeFormBuilder);
                    KoordinatorForm.vratiKoordinatorForm().postaviFormu(directorForm.Konstrujisi());
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
                Grid.SetColumn(buttonPanel, 0);
                Grid.SetRow(buttonPanel, 0);
            }
        }
    }
}
