using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomenskeKlase.Ucenik
{
    public partial class Mesto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MestoId { get; set; }
        public String Naziv { get; set; }
    }
    
}
