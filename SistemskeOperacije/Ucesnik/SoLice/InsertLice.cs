using DomenskeKlase.Ucenik;
using System.Data.Entity;
using System.Linq;

namespace SistemskeOperacije.Ucesnik.SoLice
{
    public class InsertLice : OpstaSo<Lice>
    {
        protected override void izvrsiKonkretnuOperaciju(Lice lice)
        {

            Mesto mestoDb = licitacijaDBContext.Mesto.First(m => m.MestoId == lice.Mesto.MestoId);
            lice.Mesto = mestoDb;            
            licitacijaDBContext.Entry(lice).State = EntityState.Added;
            licitacijaDBContext.SaveChanges();
        }

        protected override void proveriPreduslov(Lice lice)
        {
            if (lice is Fizicko)
            {
                Fizicko fizicko = (Fizicko)lice;
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
            else {

                Pravno pravno = (Pravno)lice;
                if (pravno.Mb == null || pravno.Mb.Equals(""))
                {
                    throw new System.ArgumentException("Mb ne moze bitu null ili prazan");
                }
                Pravno pravnoDb = licitacijaDBContext.Pravno.FirstOrDefault(x => x.Mb == pravno.Mb);
                if (pravnoDb != null)
                {
                    throw new System.ApplicationException("Entitet postoji");
                }
            
            }


            
        }
    }
}
