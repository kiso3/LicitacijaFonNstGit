using DomenskeKlase.LicitacijaPriprema;
using System.Windows.Controls;
using WpfInterface3.Director;
using WpfInterface3.Director.NadmetanjeDirector;
using WpfInterface3.KKI;
using WpfInterface3.Panel.NadmetanjePanel;
using WpfInterface3.Panel.TablePanel;
using WpfInterface3.PanelForm.NadmetanjePanelForm;

namespace WpfInterface3.Form
{
    class NadmetanjeForm : UnosForm
    {
        private NadmetanjePanelForm _nadmetanjePanelForm;

        public NadmetanjeForm(NadmetanjePanelForm nadmetanjePanelForm)
            :base(nadmetanjePanelForm)
        {
            _nadmetanjePanelForm = nadmetanjePanelForm;
        }
        public override void SetControler()
        {            
            _nadmetanjePanelForm.CBoxNadmetanjeZaGodinu.cboxNadmetanjeZaGodinu.ItemsSource = KKILicitacija.Instance.GetAllResenjeSo();

            _nadmetanjePanelForm.CBoxNadmetanjeZaGodinu.cboxNadmetanjeZaGodinu.SelectionChanged += delegate (object sender, SelectionChangedEventArgs e)
            {
                Resenje resenje = (Resenje)_nadmetanjePanelForm.CBoxNadmetanjeZaGodinu.cboxNadmetanjeZaGodinu.SelectedItem;

                NadmetanjeTableFormBuilderPrikaz nadmetanjeTableFormBuilderPrikaz = new NadmetanjeTableFormBuilderPrikaz(resenje);
                DirectorForm directorForm = new DirectorForm(nadmetanjeTableFormBuilderPrikaz);
                KoordinatorForm.vratiKoordinatorForm().postaviFormu(directorForm.Konstrujisi());
            };

            _nadmetanjePanelForm.TblNadmetanje.baseDataGrid.ItemsSource = KKILicitacija.Instance.GetAllNadmetanjeForOglasSo(_nadmetanjePanelForm.Resenje.Oglas);

        }

        public override void SetPanel()
        {
            _nadmetanjePanelForm.CBoxNadmetanjeZaGodinu = new ComboBoxNadmetanjeZaGodinu();
            _nadmetanjePanelForm.TFBrojOglasa = new TFBrojOglasa();
            _nadmetanjePanelForm.TFDatumObjave = new TFDatumObjave();
            _nadmetanjePanelForm.TFMaxPovZakupa = new TFMaxPovZakupa();
            _nadmetanjePanelForm.TblNadmetanje = new TblNadmetanje();
        }
    }
}
