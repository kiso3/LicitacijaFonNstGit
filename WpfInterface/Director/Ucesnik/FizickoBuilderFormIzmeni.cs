using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using DomenskeKlase.Ucenik;
using WpfInterface3.PanelForm.Ucenik;
using WpfInterface3.Form;
using WpfInterface3.FormKontrole.Ucesnik;
using WpfInterface3.Form.Ucesnik;

namespace WpfInterface3.Director.Ucesnik
{
    class FizickoBuilderFormIzmeni : BuilderForm
    {
        FizickoPanelForm fizickoPanelForm;        

        public FizickoBuilderFormIzmeni(Fizicko fizicko)
        {            
            fizickoPanelForm = new FizickoPanelForm(fizicko);
        }

        public UserControl GetResult()
        {
            return fizickoPanelForm;
        }

        public void KreirajFormu()
        {            
            UnosForm fizickoForm = new BtnFizickoIzmeni(new FizickoForm(fizickoPanelForm));
            fizickoForm.SetPanel();
            fizickoForm.SetControler();
            fizickoPanelForm.DisableRadioLice();
        }
    }
}
