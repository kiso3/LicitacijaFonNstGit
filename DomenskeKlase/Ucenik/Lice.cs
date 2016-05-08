using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomenskeKlase.Ucenik
{    
    public abstract partial class Lice
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]        
        public int LiceId { get; set; }
        public int Pib { get; set; }
        public String Adresa { get; set; }        
        public Mesto Mesto { get; set; }
        public String Email { get; set; }
        public String Telefon { get; set; }
    }
}
