using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomenskeKlase.Licitacija;
using DomenskeKlase.LicitacijaPriprema;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomenskeKlase.Ucenik
{
    //[Table("Komisija")]
    public partial class Komisija : Fizicko
    {
       // [ForeignKey("StrucnaSprema")]
        //[Column("StrucnaSpremaId")]
        //public int StrucnaSpremaId { get; set; }
        public StrucnaSprema StrucnaSprema { get; set; }

        public ICollection<ClanoviZapisnikKomisija> ClanoviZapisnikKomisija { get; set; }
        public ICollection<KomisijaZaIzraduPonude> KomisijaZaIzraduPonude { get; set; }
    }
}
