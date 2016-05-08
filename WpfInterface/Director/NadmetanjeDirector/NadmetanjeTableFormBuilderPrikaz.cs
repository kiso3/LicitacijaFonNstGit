using DomenskeKlase.LicitacijaPriprema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WpfInterface3.Form;
using WpfInterface3.FormKontrole.NadmetanjeFormKontrole;
using WpfInterface3.PanelForm.NadmetanjePanelForm;

namespace WpfInterface3.Director.NadmetanjeDirector
{
    class NadmetanjeTableFormBuilderPrikaz : BuilderForm
    {
        NadmetanjePanelForm nadmetanjePanelForm;

        public NadmetanjeTableFormBuilderPrikaz()
        {
            nadmetanjePanelForm = new NadmetanjePanelForm(new Resenje());
        }
        public NadmetanjeTableFormBuilderPrikaz(Resenje resenje)
        {
            nadmetanjePanelForm = new NadmetanjePanelForm(resenje);
        }
        public UserControl GetResult()
        {
            return nadmetanjePanelForm;
        }

        public void KreirajFormu()
        {            
            UnosForm nadmetanjeForm = new BtnNadmetanjePrijavePrikaz( new NadmetanjeForm(nadmetanjePanelForm));
            nadmetanjeForm.SetPanel();
            nadmetanjeForm.SetControler();
        }
    }
}
