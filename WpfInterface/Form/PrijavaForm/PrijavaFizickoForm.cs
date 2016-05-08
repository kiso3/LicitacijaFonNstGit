using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfInterface3.Form.Ucesnik;
using WpfInterface3.Panel.PrijavaPanel;
using WpfInterface3.PanelForm.PrijavaPanelForm;
using WpfInterface3.PanelForm.Ucenik;

namespace WpfInterface3.Form.PrijavaForm
{
    class PrijavaFizickoForm : PrijavaForm
    {
        private PrijavaFizickoPanelForm _prijavaFizickoPanelForm;
        public PrijavaFizickoForm(PrijavaFizickoPanelForm prijavaFizickoPanelForm)
            :base(prijavaFizickoPanelForm)
        {
            _prijavaFizickoPanelForm = prijavaFizickoPanelForm;
        }
        public override void SetControler()
        {
            base.SetControler();
        }

        public override void SetPanel()
        {
            base.SetPanel();

            FizickoPanelForm fizickoPanelForm = new FizickoPanelForm(_prijavaFizickoPanelForm.PrijavaFizicko.Fizicko);

            FizickoForm fizickoForm = new FizickoForm(fizickoPanelForm);
            fizickoForm.SetPanel();
            fizickoForm.SetControler();
            
            _prijavaFizickoPanelForm.CBoxLicnaKarta = new CBoxLicnaKarta();
            _prijavaFizickoPanelForm.CBoxDokazOGranZemlj = new CBoxDokazOGranZemlj();
            _prijavaFizickoPanelForm.FizickoPanelForm = fizickoPanelForm;

        }

        public PrijavaFizickoPanelForm PrijavaFizickoPanelForm
        {
            get { return _prijavaFizickoPanelForm; }
        }
    }
}
