using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace DomenskeKlase.Ucenik
{
    
    public partial class Fizicko : Lice
    {    
        public String Jmbg { get; set; }    
        public String Ime { get; set; }    
        public String Prezime { get; set; }    
        public String ImeRoditelja { get; set; }
    }
}
