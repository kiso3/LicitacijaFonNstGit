using WpfInterface3.KKI;
using WpfInterface3.Panel.NadmetanjePanel;
using WpfInterface3.Panel.TablePanel;
using WpfInterface3.PanelForm.NadmetanjePanelForm;

namespace WpfInterface3.Form.NademtanjeForm
{
    class PrijaveZaNadmetanjeForm : UnosForm
    {
        public PrijaveZaNadmetanjePanelForm _prijaveZaNadmetanjePanelForm;

        public PrijaveZaNadmetanjeForm(PrijaveZaNadmetanjePanelForm prijaveZaNadmetanjePanelForm)
            :base(prijaveZaNadmetanjePanelForm)
        {
            _prijaveZaNadmetanjePanelForm = prijaveZaNadmetanjePanelForm;
        }

        public override void SetControler()
        {
            _prijaveZaNadmetanjePanelForm.TblPrijave.baseDataGrid.ItemsSource =
                KKILicitacija.Instance.GetAllPrijavaForNadmetanjeSo(_prijaveZaNadmetanjePanelForm.Nadmetanje);

        }

        public override void SetPanel()
        {
            _prijaveZaNadmetanjePanelForm.TFBrojOglasa = new TFBrojOglasa();
            _prijaveZaNadmetanjePanelForm.TFDatumObjave = new TFDatumObjave();
            _prijaveZaNadmetanjePanelForm.TFMaxPovZakupa = new TFMaxPovZakupa();
            _prijaveZaNadmetanjePanelForm.TFNadmetanjeOznaka = new TFNadmetanjeOznaka();
            _prijaveZaNadmetanjePanelForm.TblPrijave = new TblPrijave();
        }
    }
}
