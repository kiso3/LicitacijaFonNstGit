using DomenskeKlase.Ucenik;
using System.Linq;

namespace SistemskeOperacije.Ucesnik.SoFizicko
{
    public class AzurirajFizicko : OpstaSo<Fizicko>
    {
        protected override void izvrsiKonkretnuOperaciju(Fizicko fizicko)
        {
            /*
            var fizickoDb = licitacijaDBContext.Fizicko.Find(fizicko.LiceId);
            licitacijaDBContext.Entry(fizickoDb).CurrentValues.SetValues(fizicko);
            licitacijaDBContext.SaveChanges();
            */
            var fizickoDb = licitacijaDBContext.Fizicko.FirstOrDefault(x => x.LiceId == fizicko.LiceId);
            var mestoDb = licitacijaDBContext.Mesto.FirstOrDefault(x => x.MestoId == fizicko.Mesto.MestoId);

            licitacijaDBContext.Entry(fizickoDb).CurrentValues.SetValues(fizicko);
            licitacijaDBContext.Entry(fizickoDb).Reference(f => f.Mesto).CurrentValue = mestoDb;

            licitacijaDBContext.SaveChanges();
        }

        protected override void proveriPreduslov(Fizicko fizicko)
        {
            if (fizicko.Jmbg == null || fizicko.Jmbg.Equals(""))
            {
                throw new System.ArgumentException("Jmbg ne moze bitu null ili prazan");
            }
        }
    }
}
