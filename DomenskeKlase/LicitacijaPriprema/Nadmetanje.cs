using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomenskeKlase.Licitacija;
using System.Runtime.Serialization;


namespace DomenskeKlase.LicitacijaPriprema
{
    [DataContract(IsReference = true)]
    public class Nadmetanje
    {
        [DataMember]
        public int NadmetanjeId { get; set; }
        [DataMember]
        public decimal PocetnaCena { get; set; }
        [DataMember]
        public DateTime? DatumNadmetanja { get; set; }
        [DataMember]
        public decimal Depozit { get; set; }
        [DataMember]
        public int? PeriodZakupa { get; set; }
        [DataMember]
        public string OznakaNadmetanja { get; set; }
        
        [DataMember]
        public Oglas Oglas { get; set; }
        [DataMember]
        public Kompleks Kompleks { get; set; }
        [DataMember]
        public HashSet<Prijava> PrijavaList { get; set; }
        //public Zapisnik Zapisnik { get; set; }
    }
}
