using DomenskeKlase.LicitacijaPriprema;
using System.Collections.Generic;
using System.Linq;

namespace SistemskeOperacije.LicitacijaPriprema.SoOglas
{
    public class GetAllOgals : OpstaSo<Oglas>
    {
        private List<Oglas> list;

        protected override void izvrsiKonkretnuOperaciju(Oglas entity)
        {
            list = licitacijaDBContext.Oglas.Include("Resenje").ToList();            
        }

        protected override void proveriPreduslov(Oglas entity)
        {
            
        }

        public List<Oglas> Getlist()
        {
            return list;
        }
    }
}
