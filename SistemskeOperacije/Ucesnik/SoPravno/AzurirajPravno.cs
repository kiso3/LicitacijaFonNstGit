using DomenskeKlase.Ucenik;
using System.Linq;

namespace SistemskeOperacije.Ucesnik.SoPravno
{
    public class AzurirajPravno : OpstaSo<Pravno>
    {
        protected override void izvrsiKonkretnuOperaciju(Pravno pravno)
        {
            /*
            var pravnoDb = licitacijaDBContext.Pravno.Find(pravno.LiceId);
            licitacijaDBContext.Entry(pravnoDb).CurrentValues.SetValues(pravno);
            licitacijaDBContext.SaveChanges();
            */

            var pravnoDb = licitacijaDBContext.Pravno.FirstOrDefault(x => x.LiceId == pravno.LiceId);
            var mestoDb = licitacijaDBContext.Mesto.FirstOrDefault(x => x.MestoId == pravno.Mesto.MestoId);

            licitacijaDBContext.Entry(pravnoDb).CurrentValues.SetValues(pravno);
            licitacijaDBContext.Entry(pravnoDb).Reference(f => f.Mesto).CurrentValue = mestoDb;

            licitacijaDBContext.SaveChanges();
        }

        protected override void proveriPreduslov(Pravno pravno)        
        {
            if (pravno.Mb == null || pravno.Mb.Equals(""))
            {
                throw new System.ArgumentException("Mb ne moze bitu null ili prazan");
            }
        }
    }
}
