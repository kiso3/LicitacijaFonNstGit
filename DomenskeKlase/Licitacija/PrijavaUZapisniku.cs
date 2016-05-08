using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomenskeKlase.Licitacija
{
    public class PrijavaUZapisniku
    {
        public int ZapisnikId { get; set; }
        public int Rb { get; set; }
        public Zapisnik Zapisnik { get; set; }
        public Prijava Prijava { get; set; }
        public double LicitiranaCena { get; set; }
        public int BrLicitatorskeKartice { get; set; }
        public bool Prisutan { get; set; }
        public bool Pobednik { get; set; }
        public String Prigovorprimedba { get; set; }
        public String Odluka { get; set; }
        public IzreceneMere IzreceneMere { get; set; }
    }
}
