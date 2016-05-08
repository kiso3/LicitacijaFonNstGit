using DomenskeKlase.Ucenik;
using System.Data.Entity;
using System.Linq;

namespace SistemskeOperacije.Ucesnik.SoPravno
{
    public class InsertPravno : OpstaSo<Pravno>
    {
        protected override void izvrsiKonkretnuOperaciju(Pravno pravno)
        {
            Mesto mestoDb = licitacijaDBContext.Mesto.First(m => m.MestoId == pravno.Mesto.MestoId);
            pravno.Mesto = mestoDb;
            licitacijaDBContext.Entry(pravno).State = EntityState.Added;
            licitacijaDBContext.SaveChanges();
            /*
            licitacijaDBContext.Pravno.Add(pravno);
            licitacijaDBContext.Entry(pravno.Mesto).State = EntityState.Modified;
            licitacijaDBContext.SaveChanges();
            */
        }

        protected override void proveriPreduslov(Pravno pravno)
        {
            if (pravno.Mb == null || pravno.Mb.Equals(""))
            {
                throw new System.ArgumentException("Mb ne moze bitu null ili prazan");
            }
            Pravno pravnoDb = licitacijaDBContext.Pravno.FirstOrDefault(x => x.Mb == pravno.Mb);
            if(pravnoDb != null)
            {
                throw new System.ApplicationException("Entitet postoji");
            }
        }
    }
}
