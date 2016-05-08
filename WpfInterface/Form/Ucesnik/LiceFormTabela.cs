using WpfInterface3.KKI;
using WpfInterface3.Panel.TablePanel;
using WpfInterface3.PanelForm.Ucesnik;

namespace WpfInterface3.Form.Ucesnik
{
    class LiceFormTabela : UnosForm
    {
        private LicePanelFormTabela _licePanelFormTabela;

        public LiceFormTabela(LicePanelFormTabela licePanelFormTabela)
            :base(licePanelFormTabela)
        {
            this._licePanelFormTabela = licePanelFormTabela;
        }

        public override void SetControler()
        {
            _licePanelFormTabela.tblLice.baseDataGrid.ItemsSource = KKILicitacija.Instance.GetAllLiceSo();
        }


        public override void SetPanel()
        {
            _licePanelFormTabela.tblLice = new TblLice();
        }

        public LicePanelFormTabela LicePanelFormTabela
        {
            get { return _licePanelFormTabela; }
        }
    }
}
