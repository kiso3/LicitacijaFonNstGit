using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomenskeKlase.ProstorniPodaci
{
    public class Objekat : ProstorniEntitet
    {
        public int ObjekatId { get; set; }
        public int DeoParceleId { get; set; }
        public int IspodPrizemlja { get; set; }
        public int Prizemlje { get; set; }
        public int Iznadprizemlja { get; set; }
        public int UPodkrovlju { get; set; }
        public int UkupnoEtaza { get; set; }
        public NacinKoriscenjaObj NacinKoriscenjaObj { get; set; }
        public String AderesaObj { get; set; }
        public PravniStatusObj PravniStatusObj { get; set; }
        public IList<DeloviObjekta> DeloviObjekta { get; set; }

        public DeoParcele DeoParcele { get; set; }

    }
}
