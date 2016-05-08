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

    [MetadataType(typeof(Pravno))]
    [DataContract]
    public partial class Pravno
    {
        [DataMember]
        [Required]
        [Display(Name = "MB")]
        [MaxLength(8)]
        public String Mb;

        [DataMember]
        [Display(Name = "Naziv")]
        [MaxLength(100)]
        public String Naziv;

    }
}
