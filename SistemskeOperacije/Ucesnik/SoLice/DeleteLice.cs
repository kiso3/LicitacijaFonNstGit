using DomenskeKlase.Ucenik;

namespace SistemskeOperacije.Ucesnik.SoLice
{
    public class DeleteLice : OpstaSo<Lice>
    {
        protected override void izvrsiKonkretnuOperaciju(Lice lice)
        {
            var liceDb = licitacijaDBContext.Lice.Find(lice.LiceId);
            licitacijaDBContext.Lice.Remove(liceDb);            
            licitacijaDBContext.SaveChanges();

        }

        protected override void proveriPreduslov(Lice entity)
        {
            
        }
    }
}
