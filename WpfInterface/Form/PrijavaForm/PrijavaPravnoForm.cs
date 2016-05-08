using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfInterface3.Form.Ucesnik;
using WpfInterface3.Panel.PrijavaPanel;
using WpfInterface3.PanelForm.PrijavaPanelForm;
using WpfInterface3.PanelForm.Ucesnik;

namespace WpfInterface3.Form.PrijavaForm
{
    class PrijavaPravnoForm : PrijavaForm
    {
        private PrijavaPravnoPanelForm _prijavaPravnoPanelForm;
        public PrijavaPravnoForm(PrijavaPravnoPanelForm prijavaPravnoPanelForm)
            :base(prijavaPravnoPanelForm)
        {
            _prijavaPravnoPanelForm = prijavaPravnoPanelForm;
        }
        public override void SetControler()
        {
            base.SetControler();
        }

        public override void SetPanel()
        {
            base.SetPanel();

            PravnoPanelForm pravnoPanelForm = new PravnoPanelForm(_prijavaPravnoPanelForm.PrijavaPravno.Pravno);

            PravnoForm pravnoForm = new PravnoForm(pravnoPanelForm);
            pravnoForm.SetPanel();
            pravnoForm.SetControler();

            _prijavaPravnoPanelForm.CBoxPrivredniRegistar = new CBoxPrivredniRegistar();
            _prijavaPravnoPanelForm.PravnoPanelForm = pravnoPanelForm;

        }

        public PrijavaPravnoPanelForm PrijavaPravnoPanelForm
        {
            get { return _prijavaPravnoPanelForm; }
        }
    }
}
