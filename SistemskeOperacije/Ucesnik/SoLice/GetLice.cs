using DomenskeKlase.Ucenik;
using System;
using System.Linq;

namespace SistemskeOperacije.Ucesnik.SoLice
{
    public class GetLice : OpstaSo<Lice>
    {
        private Lice lice;

        protected override void izvrsiKonkretnuOperaciju(Lice lice)
        {
            if (lice is Fizicko)
            {                
                this.lice = licitacijaDBContext.Fizicko.Include("Mesto").FirstOrDefault(x => x.Jmbg == ((Fizicko)lice).Jmbg);
            }
            else
            {
                this.lice = licitacijaDBContext.Pravno.Include("Mesto").FirstOrDefault(x => x.Mb == ((Pravno)lice).Mb);
            }
        }

        protected override void proveriPreduslov(Lice entity)
        {
            throw new NotImplementedException();
        }

        public Lice GetObject() 
        {
            return lice;
        }
    }
}
