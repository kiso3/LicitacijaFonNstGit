using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfInterface3.Form;

namespace WpfInterface3.FormKontrole
{
    abstract class DecoratorForm : UnosForm
    {
        public UnosForm unosForm;

        public DecoratorForm(UnosForm unosForm)
            :base(unosForm.panelForm)
        {
            this.unosForm = unosForm;
        }

        public override void SetControler()
        {
            unosForm.SetControler();
        }

        public override void SetPanel()
        {
            unosForm.SetPanel();
        }
    }
}
