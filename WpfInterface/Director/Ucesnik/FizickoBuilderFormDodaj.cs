using DomenskeKlase.Ucenik;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WpfInterface3.Form;
using WpfInterface3.Form.Ucesnik;
using WpfInterface3.FormKontrole.Ucesnik;
using WpfInterface3.PanelForm.Ucenik;

namespace WpfInterface3.Director.Ucesnik
{
    class FizickoBuilderFormDodaj : BuilderForm
    {
        FizickoPanelForm fizickoPanelForm;
        public UserControl GetResult()
        {
            return fizickoPanelForm;
        }

        public void KreirajFormu()
        {            
            this.fizickoPanelForm = new FizickoPanelForm(new Fizicko());
            UnosForm fizickoForm = new BtnFizickoDodaj(new FizickoForm(fizickoPanelForm));
            fizickoForm.SetPanel();
            fizickoForm.SetControler();
        }
    }
}
