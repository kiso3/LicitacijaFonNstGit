using DomenskeKlase.LicitacijaPriprema;
using System.Windows;
using System.Windows.Controls;
using WpfInterface3.Director;
using WpfInterface3.Director.NadmetanjeDirector;
using WpfInterface3.Form;
using WpfInterface3.Panel;
using WpfInterface3.PanelForm.PrijavaPanelForm;

namespace WpfInterface3.FormKontrole.PrijavaFormKontrole
{
    class BtnPrijavaNazad : DecoratorForm
    {
        public ButtonPanel buttonPanel;        

        public BtnPrijavaNazad(UnosForm unosForm) : base(unosForm)
        {
            buttonPanel = new ButtonPanel("Nazad");
            buttonPanel.Margin = new Thickness(2);            
        }

        public override void SetControler()
        {
            base.SetControler();

            //new KontrolerBtnPrijavaNazad(this);
            
            PrijavaPanelForm prijavaPanelForm = panelForm as PrijavaPanelForm;

            buttonPanel.btn.Click += delegate (object sender, RoutedEventArgs e)
            {
                Nadmetanje nadmetanje = prijavaPanelForm.Prijava.Nadmetanje;
                nadmetanje.PrijavaList = null;
                //nadmetanje.Oglas.Resenje = null;
                if (nadmetanje != null)
                {
                    PrijaveZaNadmetanjeFormBuilder prijaveZaNadmetanjeFormBuilder = new PrijaveZaNadmetanjeFormBuilder(nadmetanje);
                    DirectorForm directorForm = new DirectorForm(prijaveZaNadmetanjeFormBuilder);
                    KoordinatorForm.vratiKoordinatorForm().postaviFormu(directorForm.Konstrujisi());
                }
            };

        }
        public override void SetPanel()
        {
            base.SetPanel();
            if (unosForm.panelForm is PrijavaPanelForm)
            {
                PrijavaPanelForm prijavaPanelForm = unosForm.panelForm as PrijavaPanelForm;
                prijavaPanelForm.gridBase.Children.Add(buttonPanel);
                Grid.SetColumn(buttonPanel, 0);
                Grid.SetRow(buttonPanel, 0);
            }
        }
    }
}
