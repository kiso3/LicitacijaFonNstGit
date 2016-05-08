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
    public class PrijavaPravno : Prijava
    {
        [DataMember]
        public bool IzvodizprivrednogRegistra { get; set; }
        [DataMember]
        public Pravno Pravno { get; set; }
    }
}
