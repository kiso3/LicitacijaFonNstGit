using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomenskeKlase.ProstorniPodaci;
using System.Runtime.Serialization;


namespace DomenskeKlase.LicitacijaPriprema
{
    [DataContract(IsReference = true)]
    public class Kompleks
    {
        [DataMember]
        public int KompleksId { get; set; }
        [DataMember]
        public DateTime? DatumKreiranja { get; set; }
        [DataMember]
        public int Povrsina { get; set; }
        [DataMember]
        public int PovrsinaPodObj { get; set; }

        //public ICollection<ProstorniEntitet> ProstorniEntitet { get; set; }
        [DataMember]
        public HashSet<Nadmetanje> Nadmetanje { get; set; }

    }
}
