using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DomenskeKlase.LicitacijaPriprema
{
     [DataContract(IsReference=true)] 
    public class Resenje
    {
         [DataMember]
        public int ResenjeId { get; set; }
         //[DataMember]
        //public int OpstinaId { get; set; }
         [DataMember]
        public DateTime? DaumSednice { get; set; }
         [DataMember]
        public String SluzbeniListBr { get; set; }
         [DataMember]
        public String ClasnStatuta { get; set; }
         [DataMember]
        public DateTime? DarumIzradeResenja { get; set; }
         [DataMember]
        public DateTime ZaGodinu { get; set; }
         [DataMember]
        public String TekstOdluke { get; set; }
         
        //public ICollection<KomisijaZaIzraduPonude> KomisijaZaIzraduPonude { get; set; }
         [DataMember]
        public  Oglas Oglas { get; set; }
        //public ZahtevZaPoljZemlj ZahtevZaPoljZemlj { get; set; }
    }
}
