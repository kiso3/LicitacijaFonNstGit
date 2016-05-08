using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomenskeKlase.Ucenik
{
    public partial class Pravno : Lice
    {
        public String Mb { get; set; }
        public String Naziv { get; set; }    
    }
}
