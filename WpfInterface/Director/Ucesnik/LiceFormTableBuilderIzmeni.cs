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
    class LiceFormTableBuilderIzmeni : BuilderForm
    {
        LicePanelFormTabela licePanelFormTabela;
        public UserControl GetResult()
        {
            return licePanelFormTabela;
        }

        public void KreirajFormu()
        {
            licePanelFormTabela = new LicePanelFormTabela();           
            UnosForm LiceFormTabela = new BtnTableLiceDodaj(new BtnTableLiceIzmeni(new BtnTableLiceObrisi(new LiceFormTabela(licePanelFormTabela))));
            LiceFormTabela.SetPanel();
            LiceFormTabela.SetControler();
        }
    }
}
