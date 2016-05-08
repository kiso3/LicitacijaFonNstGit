using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfInterface3.Panel.Ucesnik;
using WpfInterface3.PanelForm.Ucenik;

namespace WpfInterface3.Form.Ucesnik
{
    class FizickoForm : LiceForm
    {
        private FizickoPanelForm _fizickoPanelForm;
        public FizickoForm(FizickoPanelForm fizickoPanelForm)
            :base(fizickoPanelForm)
        {
            this._fizickoPanelForm = fizickoPanelForm;
        }
        public override void SetControler()
        {
            base.SetControler();
        }

        public override void SetPanel()            
        {
            base.SetPanel();

            _fizickoPanelForm.tfJmbg = new TFJmbg();
            _fizickoPanelForm.tfIme = new TFIme();
            _fizickoPanelForm.tfImeRoditelja = new TFImeRoditelja();
            _fizickoPanelForm.tfPrezime = new TFPrezime();
            _fizickoPanelForm.radioLice.radioFizicko.IsChecked = true;
        }

        public FizickoPanelForm FizickoPanelForm
        {
            get { return _fizickoPanelForm; }
        }
    }
}
