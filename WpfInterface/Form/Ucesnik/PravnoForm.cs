using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfInterface3.PanelForm.Ucenik;
using WpfInterface3.Panel.Ucesnik;
using WpfInterface3.PanelForm.Ucesnik;

namespace WpfInterface3.Form.Ucesnik
{
    class PravnoForm : LiceForm
    {
        private PravnoPanelForm _pravnoPanelForm;
        
        public PravnoForm(PravnoPanelForm pravnoPanelForm) 
            : base(pravnoPanelForm)
        {
            this._pravnoPanelForm = pravnoPanelForm;
        }

        public override void SetControler()
        {
            base.SetControler();
        }

        public override void SetPanel()
        {
            base.SetPanel();

            _pravnoPanelForm.tfMb = new TFMb();
            _pravnoPanelForm.tfNaziv = new TFNaziv();

            _pravnoPanelForm.radioLice.radioPravno.IsChecked = true;
        }

        public PravnoPanelForm PravnoPanelForm
        {
            get { return _pravnoPanelForm; }
        }
    }
}
