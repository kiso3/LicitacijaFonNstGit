using DomenskeKlase.LicitacijaPriprema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfInterface3.PanelForm.Ucesnik;

namespace WpfInterface3.PanelForm.PrijavaPanelForm
{
    class LicePrijavaPanelFormTabela : LicePanelFormTabela
    {
        private Nadmetanje _nadmetanje;

        public LicePrijavaPanelFormTabela(Nadmetanje nadmetanje)
            :base()
        {
            _nadmetanje = nadmetanje;
        }

        public Nadmetanje Nadmetanje
        {
            get { return _nadmetanje; }
        }
    }
}
