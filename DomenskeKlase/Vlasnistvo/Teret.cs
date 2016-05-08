using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DomenskeKlase.Vlasnistvo
{
    public class Teret : UpisPrava
    {
        //public int TeretId { get; set; }
        public DateTime Datumupisa { get; set; }
        public int Trajanje { get; set; }
        public VrstaTereta Vrstatereta { get; set; }
        public DateTime DatumBrisanja { get; set; }
    }
}
