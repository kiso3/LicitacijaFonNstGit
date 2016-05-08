using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomenskeKlase.Ucenik;
using DomenskeKlase.ProstorniPodaci;


namespace DomenskeKlase.Vlasnistvo
{
    public abstract class UpisPrava
    {
        public int UpisPravaId { get; set; }
        public ProstorniEntitet ProstorniEntitet { get; set; }
        public Vlasnik Vlasnik { get; set; }
    }
}
    