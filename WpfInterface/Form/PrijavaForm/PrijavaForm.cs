using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfInterface3.Panel.PrijavaPanel;
using WpfInterface3.PanelForm.PrijavaPanelForm;

namespace WpfInterface3.Form.PrijavaForm
{
    abstract class PrijavaForm : UnosForm
    {
        private PrijavaPanelForm _prijavaPanelForm;
        public PrijavaForm(PrijavaPanelForm prijavaPanelForm)
            :base(prijavaPanelForm)
        {
            _prijavaPanelForm = prijavaPanelForm;
        }
        public override void SetControler()
        {
            
        }

        public override void SetPanel()
        {                    
            _prijavaPanelForm.RBtnObilazakZemlj = new RBtnObilazakZemlj();
            _prijavaPanelForm.DatePickerDatumObilaska = new DatePickerDatumObilaska();
            _prijavaPanelForm.CBoxRegPoljGazd = new CBoxRegPoljGazd();
            _prijavaPanelForm.CBDepozit = new CBoxDepozit();
            _prijavaPanelForm.CBoxDokazOVlasnistvu = new CBoxDokazOVlasnistvu();
            _prijavaPanelForm.CBoxResenjePio = new CBoxResenjePio();
        }

        public PrijavaPanelForm PrijavaPanelForm
        {
            get { return _prijavaPanelForm; }
        }
    }
}
