using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomenskeKlase.Ucenik;
using DomenskeKlase.LicitacijaPriprema;

namespace DomenskeKlase.Licitacija
{
    public class ClanoviZapisnikKomisija
    {
        
        public int ZapisnikId { get; set; }
        public int LiceId { get; set; }
        public int UlogaClanaKomisijeId { get; set; }
        public Zapisnik Zapisnik { get; set; }
        public Komisija Komisija { get; set; }
        public UlogaClanaKomisije UlogaClanaKomisije { get; set; }
        
    }
}
