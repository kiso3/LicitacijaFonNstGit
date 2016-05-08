using WpfInterface3.KKI;
using WpfInterface3.Panel.TablePanel;
using WpfInterface3.PanelForm.PrijavaPanelForm;

namespace WpfInterface3.Form.Ucesnik
{
    class LicePrijavaFormTable : UnosForm
    {
        private LicePrijavaPanelFormTabela _licePrijavaPanelFormTabela;
        public LicePrijavaFormTable(LicePrijavaPanelFormTabela licePrijavaPanelFormTabela)
            :base(licePrijavaPanelFormTabela)
        {
            _licePrijavaPanelFormTabela = licePrijavaPanelFormTabela;
        }

        public override void SetControler()
        {                     
            _licePrijavaPanelFormTabela.tblLice.baseDataGrid.ItemsSource = KKILicitacija.Instance.GetAllLicaForPrijavaSo(_licePrijavaPanelFormTabela.Nadmetanje);

        }
        public override void SetPanel()
        {
            _licePrijavaPanelFormTabela.tblLice = new TblLice();
        }
        public LicePrijavaPanelFormTabela LicePrijavaPanelFormTabela
        {
            get { return _licePrijavaPanelFormTabela; }
        }
    }
}
