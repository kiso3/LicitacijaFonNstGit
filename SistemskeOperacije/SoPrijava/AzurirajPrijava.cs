using DomenskeKlase.Licitacija;

namespace SistemskeOperacije.SoPrijava
{
    public class AzurirajPrijava : OpstaSo<Prijava>
    {
        protected override void izvrsiKonkretnuOperaciju(Prijava prijava)
        {
            var prijavaDb = licitacijaDBContext.Prijava.Find(prijava.PrijavaId);
            licitacijaDBContext.Entry(prijavaDb).CurrentValues.SetValues(prijava);
            licitacijaDBContext.SaveChanges();
        }

        protected override void proveriPreduslov(Prijava entity)
        {
            
        }
    }
}
