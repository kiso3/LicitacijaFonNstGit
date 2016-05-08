using DomenskeKlase.LicitacijaPriprema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WpfInterface3.Form;
using WpfInterface3.Form.NademtanjeForm;
using WpfInterface3.FormKontrole.NadmetanjeFromKontole;
using WpfInterface3.PanelForm.NadmetanjePanelForm;

namespace WpfInterface3.Director.NadmetanjeDirector
{
    class PrijaveZaNadmetanjeFormBuilder : BuilderForm
    {
        PrijaveZaNadmetanjePanelForm prijaveZaNadmetanjePanelForm;

        public PrijaveZaNadmetanjeFormBuilder(Nadmetanje nadmetaje)
        {
            prijaveZaNadmetanjePanelForm = new PrijaveZaNadmetanjePanelForm(nadmetaje);
        }

        public UserControl GetResult()
        {
            return prijaveZaNadmetanjePanelForm;
        }

        public void KreirajFormu()
        {
            UnosForm prijavaZaNadmetanjeForm = 
                new BtnNadmetanjeTableNazad(
                    new BtnTablePrijavaObrisi(
                        new BtnTablePrijavaIzmeni(
                            new BtnTableOdabirPonudjacaDodaj(
                        new PrijaveZaNadmetanjeForm(prijaveZaNadmetanjePanelForm)
                    ))));
            prijavaZaNadmetanjeForm.SetPanel();
            prijavaZaNadmetanjeForm.SetControler();
         }
    }
}
