using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomenskeKlase.Vlasnistvo;

namespace DomenskeKlase.Ucenik
{    
    public partial class Vlasnik : Lice
    {
        public ICollection<UpisPrava> UpisPrava { get; set; }
    }
}
