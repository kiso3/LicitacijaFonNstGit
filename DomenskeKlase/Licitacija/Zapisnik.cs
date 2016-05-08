using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomenskeKlase.LicitacijaPriprema;

namespace DomenskeKlase.Licitacija
{
    public class Zapisnik
    {
        public int ZapisnikId { get; set; }
        public bool Odrzana { get; set; }
        public String Mesto { get; set; }
        public String AdresaLicitacije { get; set; }
        public DateTime DatumVremePocetka { get; set; }
        public DateTime DatumVremeZavrsetka { get; set; }
        public Nadmetanje Nadmetanje { get; set; }
        public HashSet<PrijavaUZapisniku> PrijavaUZapisniku { get; set; }
        public HashSet<ClanoviZapisnikKomisija> ClanoviZapisnikKomisije { get; set; }
    }
}
