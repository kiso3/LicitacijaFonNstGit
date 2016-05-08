using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomenskeKlase.ProstorniPodaci
{
    public class DeloviObjekta : ProstorniEntitet
    {
        public int DeloviObjektaId { get; set; }
        public int ObjekatId { get; set; }
        public int EvidencijskiBroj { get; set; }
        public int OsnovniObj { get; set; }
        public int PodbrojObj { get; set; }
        public decimal Korisnapov { get; set; }
        public NacinKoriscenjaDelaObj NacinKoriscenjaDelaObj { get; set; }
        public String Sobnost { get; set; }
        public String AdresaposebnogDelaObj { get; set; }

        public Spratnost Spratnost { get; set; }

        public Objekat Objekat { get; set; }
    }
}
