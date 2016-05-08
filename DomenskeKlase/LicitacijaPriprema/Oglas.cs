using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


namespace DomenskeKlase.LicitacijaPriprema
{
    [DataContract(IsReference=true)]
    public class Oglas
    {
        [DataMember]
        public int OglasId { get; set; }      
        [DataMember]
        public DateTime DatumObjave { get; set; }
        [DataMember]
        public int MaxpovZakupa { get; set; }

        [DataMember]
        public Resenje Resenje { get; set; }
        [DataMember]
        public HashSet<Nadmetanje> NadmetanjeList { get; set; }   
    }
}
