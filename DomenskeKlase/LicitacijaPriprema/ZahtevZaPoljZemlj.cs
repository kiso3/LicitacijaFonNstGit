using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomenskeKlase.Ucenik;

namespace DomenskeKlase.LicitacijaPriprema
{
    public class ZahtevZaPoljZemlj
    {
        public int ZahtevZapoljZemljId { get; set; }
        public int ResenjeId { get; set; }
        public int SluzbaKnId { get; set; }
        public int KontaktOsobaid { get; set; }
        public DateTime DatunPodnosenja { get; set; }
        public String NazivOdeljenja { get; set; }

        //public Resenje Resnje { get; set; }
        public SluzbaKn SluzbaKn { get; set; }
        public KontaktOsoba KontaktOsoba { get; set; }

    }
}
