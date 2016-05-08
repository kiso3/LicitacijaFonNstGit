using DomenskeKlase.Licitacija;

namespace SistemskeOperacije.SoPrijava
{
    public class DeletePrijava : OpstaSo<Prijava>
    {
        protected override void izvrsiKonkretnuOperaciju(Prijava prijava)
        {
            var prijavaDb = licitacijaDBContext.Prijava.Find(prijava.PrijavaId);
            licitacijaDBContext.Prijava.Remove(prijavaDb);
            licitacijaDBContext.SaveChanges();
        }

        protected override void proveriPreduslov(Prijava prijava)
        {
            
        }
    }
}
