using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomenskeKlase.ProstorniPodaci
{
    public class Ko : ProstorniEntitet
    {
        public int KoId { get; set; }
        public String NazivKo { get; set; }
        public IList<Parcela> Parcela { get; set; }
    }
}
