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
using WpfInterface3.PanelForm.Ucesnik;

namespace WpfInterface3.Director.Ucesnik
{
    class PravnoBuilderFormDodaj : BuilderForm
    {
        PravnoPanelForm pravnoPanelForm; 
        public UserControl GetResult()
        {
            return pravnoPanelForm;
        }

        public void KreirajFormu()
        {
            this.pravnoPanelForm = new PravnoPanelForm(new Pravno());
            UnosForm fizickoForm = new BtnPravnoDodaj(new PravnoForm(pravnoPanelForm));
            fizickoForm.SetPanel();
            fizickoForm.SetControler();
        }
    }
}
