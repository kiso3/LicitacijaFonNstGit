using DomenskeKlase.Ucenik;

namespace SistemskeOperacije.Ucesnik.SoMesto
{
    public class DeleteMesto : OpstaSo<Mesto>
    {

        protected override void izvrsiKonkretnuOperaciju(Mesto mesto)
        {
            //LicitacijaDBContext.getInstance().Mesto.Attach(mesto);
            var mestoDb = licitacijaDBContext.Mesto.Find(mesto.MestoId);
            licitacijaDBContext.Mesto.Remove(mestoDb);
            licitacijaDBContext.SaveChanges();
        }

        protected override void proveriPreduslov(Mesto mesto)
        {
            
        }
    }
}
