using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomenskeKlase.Ucenik
{    
    public partial class StrucnaSprema
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StrucnaSpremaId { get; set; }
        public String Naziv { get; set; }        
    }
}
