using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomenskeKlase.Ucenik;
using DomenskeKlase.LicitacijaPriprema;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace DomenskeKlase.Licitacija
{
    [DataContract(IsReference = true)]
    public abstract class Prijava
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DataMember]
        public int PrijavaId { get; set; }                   
        [DataMember]
        public DateTime? Datumpodnosenja { get; set; }
        [DataMember]
        public String UMestu { get; set; }
        [DataMember]
        public bool ResenjePio { get; set; }
        [DataMember]
        public bool DokazOVlasnistvu { get; set; }
        [DataMember]
        public bool RegistarPoljGazd { get; set; }
        [DataMember]
        public bool UpoznatSaPonudom { get; set; }
        [DataMember]
        public DateTime? DatumObilaska { get; set; }
        [DataMember]
        public bool DokazOUplatiDepozita { get; set; }
        [DataMember]
        public bool? Obisao { get; set; }
        //public Ponudjac Ponudjac { get; set; }        
        [DataMember]
        public Predstavnik Predstavnik { get; set; }
        [DataMember]
        public Nadmetanje Nadmetanje { get; set; }
        //[DataMember]
        //public int NadmetanjeId { get; set; }
        [DataMember]
        public PrijavaUZapisniku PrijavaUZapisniku { get; set; }

    }
}
