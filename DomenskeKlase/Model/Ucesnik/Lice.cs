using DomenskeKlase.Ucenik;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DomenskeKlase.Model.Ucesnik
{
 
    [MetadataType(typeof(Lice))]
    [DataContract]
    public partial class Lice
    {
        [DataMember]
        [Display(Name = "PIB")]
        [MaxLength(10)]
        public int Pib;
        
        [DataMember]
        [Display(Name = "Adresa")] 
        [MaxLength(100)]
        public String Adresa;

        [DataMember]
        [Display(Name = "Mesto")]
        public Mesto Mesto;

        [DataMember]
        [Display(Name = "Email")]
        [MaxLength(50)]
        public String Email;

        [DataMember]
        [Display(Name = "Telefon")]
        [MaxLength(50)]
        public String Telefon;
    }
}
