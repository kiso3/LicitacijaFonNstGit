using DomenskeKlase.Ucenik;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DomenskeKlase.Licitacija
{
    [DataContract]
    public class PrijavaFizicko : Prijava
    {
        [DataMember]
        public bool LicnaKarta { get; set; }
        [DataMember]
        public bool DokazOGranicnomZemljistu { get; set; }
        [DataMember]
        public Fizicko Fizicko { get; set; } 
        
    }
}
