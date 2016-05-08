using DomenskeKlase.Ucenik;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WpfInterface3.Form;
using WpfInterface3.Form.Ucesnik;
using WpfInterface3.FormKontrole;
using WpfInterface3.FormKontrole.Ucesnik;
using WpfInterface3.PanelForm.Ucesnik;

namespace WpfInterface3.Director.Ucesnik
{
    class PravnoBuilderFormIzmeni : BuilderForm
    {
        PravnoPanelForm pravnoPanelForm;


        public PravnoBuilderFormIzmeni(Pravno pravno)
        {
            pravnoPanelForm = new PravnoPanelForm(pravno);
        }

        UserControl BuilderForm.GetResult()
        {
            return pravnoPanelForm;
        }

        void BuilderForm.KreirajFormu()
        {            
            UnosForm fizickoForm = new BtnParavnoIzmeni(new PravnoForm(pravnoPanelForm));
            fizickoForm.SetPanel();
            fizickoForm.SetControler();
            pravnoPanelForm.DisableRadioLice();
        }
    }
}
