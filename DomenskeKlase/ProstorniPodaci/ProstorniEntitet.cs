using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomenskeKlase.Vlasnistvo;
using DomenskeKlase.LicitacijaPriprema;

namespace DomenskeKlase.ProstorniPodaci
{
    public abstract class ProstorniEntitet
    {
        public int ProstorniEntitetId { get; set; }
        public double Povrsina { get; set; }
        //public IList<ProstorniEntitet> Podredjen { get; set; }
        public ICollection<UpisPrava> UpisPrava { get; set; }
        //public IList<Kompleks> Kompleks { get; set; }

        public int? NadredjeniId { get; set; }

        public ProstorniEntitet Nadredjeni { get; set; }
        public IList<ProstorniEntitet> Podredjeni { get; set; }

    }
}
