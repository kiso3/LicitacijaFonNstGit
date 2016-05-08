using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomenskeKlase.Ucenik;

namespace DomenskeKlase.Vlasnistvo
{
   public class VlsnikNepo : UpisPrava
    {
        //public int VlasnikNepoId { get; set; }
        public VrstaPrava VrstaPrava { get; set; }
        public OblikSvojine OblikSvojine { get; set; }
        public decimal Udeo { get; set; }
        
    }
}
