using System.Linq;
using DomenskeKlase.Ucenik;
using System.Data.Entity;

namespace SistemskeOperacije.Ucesnik.SoFizicko
{
    public class InsertFizicko : OpstaSo<Fizicko>
    {

        protected override void izvrsiKonkretnuOperaciju(Fizicko fizicko)
        {
            Mesto mestoDb = licitacijaDBContext.Mesto.First(m => m.MestoId == fizicko.Mesto.MestoId);
            fizicko.Mesto = mestoDb;
            licitacijaDBContext.Entry(fizicko).State = EntityState.Added;
            licitacijaDBContext.SaveChanges();
            /*
            licitacijaDBContext.Fizicko.Add(fizicko);
            licitacijaDBContext.Entry(fizicko.Mesto).State = EntityState.Modified;
            licitacijaDBContext.SaveChanges();
            */
        }

        protected override void proveriPreduslov(Fizicko fizicko)
        {
            if (fizicko.Jmbg == null || fizicko.Jmbg.Equals(""))
            {
                throw new System.ArgumentException("Jmbg ne moze bitu null ili prazan");
            }

            Fizicko fizickoDb = licitacijaDBContext.Fizicko.FirstOrDefault(x => x.Jmbg == fizicko.Jmbg);
            if (fizickoDb != null)
            {
                throw new System.ApplicationException("Entitet postoji");
            }
        }
    }
}
