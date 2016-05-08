using DomenskeKlase.Ucenik;
using System.Linq;

namespace SistemskeOperacije.Ucesnik.SoFizicko
{
    public class GetFizicko : OpstaSo<Fizicko>
    {
        private Fizicko fizicko;

        protected override void izvrsiKonkretnuOperaciju(Fizicko fizicko)
        {

            this.fizicko = licitacijaDBContext.Fizicko.Include("Mesto").FirstOrDefault(x => x.Jmbg == fizicko.Jmbg);
        }

        protected override void proveriPreduslov(Fizicko fizicko)
        {
            if (fizicko.Jmbg == null || fizicko.Jmbg.Equals(""))
            {
                throw new System.ArgumentException("Jmbg ne moze bitu null ili prazan");
            }
        }

        public Fizicko GetObject()
        {
            return fizicko;
        }
    }
}
