using DomenskeKlase.Ucenik;
using System.Linq;

namespace SistemskeOperacije.Ucesnik.SoLice
{
    public class AzurirajLice : OpstaSo<Lice>
    {
        protected override void izvrsiKonkretnuOperaciju(Lice lice)
        {
            
            var liceDb = licitacijaDBContext.Lice.FirstOrDefault(x => x.LiceId == lice.LiceId);
            var mestoDb = licitacijaDBContext.Mesto.FirstOrDefault(x => x.MestoId == lice.Mesto.MestoId);
           
            licitacijaDBContext.Entry(liceDb).CurrentValues.SetValues(lice);
            licitacijaDBContext.Entry(liceDb).Reference(l => l.Mesto).CurrentValue = mestoDb;

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
            }
            else
            {
                Pravno pravno = (Pravno)lice;
                if (pravno.Mb == null || pravno.Mb.Equals(""))
                {
                    throw new System.ArgumentException("Mb ne moze bitu null ili prazan");
                }
            }
        }
    }
}
