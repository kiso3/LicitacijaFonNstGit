using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomenskeKlase.Licitacija
{
    public class Ugovor
    {
        public int UgovorId { get; set; }
        public Zapisnik Zapisnik { get; set; }
        public Garancije Garancije { get; set; }
        public DateTime DatumKreiranja { get; set; }
        public double CenaZakupa { get; set; }
        public String Tekst { get; set; }
    }
}
