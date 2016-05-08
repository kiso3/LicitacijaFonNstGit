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
    class PrijavaFizickoBuilderFormDodaj : BuilderForm
    {
        PrijavaFizickoPanelForm prijavaFizickoPanelForm;

        public PrijavaFizickoBuilderFormDodaj(PrijavaFizicko prijavaFizicko)
        {
            prijavaFizickoPanelForm = new PrijavaFizickoPanelForm(prijavaFizicko);
        }

        public UserControl GetResult()
        {
            return prijavaFizickoPanelForm;
        }

        public void KreirajFormu()
        {
            UnosForm prijavaFizickoForm = new BtnPrijavaNazad( new BtnPrijavaDodaj( new PrijavaFizickoForm(prijavaFizickoPanelForm)));
            prijavaFizickoForm.SetPanel();
            prijavaFizickoForm.SetControler();
            prijavaFizickoPanelForm.FizickoPanelForm.DisableRadioLice();

        }
    }
}
