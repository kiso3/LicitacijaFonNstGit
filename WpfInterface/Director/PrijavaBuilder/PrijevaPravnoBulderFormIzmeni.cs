using DomenskeKlase.Licitacija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WpfInterface3.Form;
using WpfInterface3.Form.PrijavaForm;
using WpfInterface3.FormKontrole.PrijavaFormKontrole;
using WpfInterface3.PanelForm.PrijavaPanelForm;

namespace WpfInterface3.Director.PrijavaBuilder
{ 
    class PrijevaPravnoBulderFormIzmeni : BuilderForm
    {
    
        PrijavaPravnoPanelForm prijavaPravnoPanelForm;

        public PrijevaPravnoBulderFormIzmeni(PrijavaPravno prijavaPravno)
        {
            prijavaPravnoPanelForm = new PrijavaPravnoPanelForm(prijavaPravno);
        }

        public UserControl GetResult()
        {
            return prijavaPravnoPanelForm;
        }

        public void KreirajFormu()
        {
            UnosForm prijavaFizickoForm = new BtnPrijavaNazad( new BtnPrijavaIzmeni(new PrijavaPravnoForm(prijavaPravnoPanelForm)));
            prijavaFizickoForm.SetPanel();
            prijavaFizickoForm.SetControler();
            prijavaPravnoPanelForm.PravnoPanelForm.DisableRadioLice();
        }
    }
}
