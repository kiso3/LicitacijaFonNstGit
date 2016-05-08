using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomenskeKlase.Ucenik;

namespace DomenskeKlase.LicitacijaPriprema
{
    public class KomisijaZaIzraduPonude
    {
        public int KomisijaZaIzraduPonudeId { get; set; }
        public int ResenjeId { get; set; }
        public UlogaClanaKomisije UlogaClanaKomisije { get; set; }
        public int KomisijaId { get; set; }

        public Resenje Resenje { get; set; }
        public Komisija Komisija { get; set; }


    }
}
