using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomenskeKlase.ProstorniPodaci
{
    public class Parcela : ProstorniEntitet
    {
        public int ParcelaId { get; set; }
        public int Osnovni { get; set; }
        public int Podbroj { get; set; }
        public String PotesUlica { get; set; }
        public VrstaZemljista VrstaZemljista { get; set; }
        public int KoId { get; set; }        
        public IList<DeoParcele> DeoParcele { get; set; }
        
        
        public Ko Ko { get; set; }
        
    }
}
