using DomenskeKlase.Ucenik;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DomenskeKlase.Model.Ucesnik
{    

    [MetadataType(typeof(Fizicko))]    
    public partial class Fizicko
    {       
        [Required]
        [Display(Name = "JMBG")]
        [MaxLength(13)]
        public String Jmbg;
      
        [Display(Name = "Ime")]
        [MaxLength(50)]
        public String Ime;

        [Display(Name = "Prezime")]
        [MaxLength(50)]
        public String Prezime;

        [Display(Name = "Ime roditelja")]
        [MaxLength(10)]
        public String ImeRoditelja;        
    }
}
