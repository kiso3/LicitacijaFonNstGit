using DomenskeKlase.Ucenik;

namespace SistemskeOperacije.Ucesnik.SoMesto
{
    public class AzurirajMesto : OpstaSo<Mesto>
    {

        protected override void izvrsiKonkretnuOperaciju(Mesto mesto)
        {            
            var mestoDb = licitacijaDBContext.Mesto.Find(mesto.MestoId);
            licitacijaDBContext.Mesto.Attach(mesto);
            licitacijaDBContext.SaveChanges();
        }

        protected override void proveriPreduslov(Mesto entity)
        {
            
        }
    }
}
