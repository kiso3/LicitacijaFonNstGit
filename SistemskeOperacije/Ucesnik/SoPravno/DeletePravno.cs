using DomenskeKlase.Ucenik;

namespace SistemskeOperacije.Ucesnik.SoPravno
{
    public class DeletePravno : OpstaSo<Pravno>
    {
        protected override void izvrsiKonkretnuOperaciju(Pravno pravno)
        {
            //LicitacijaDBContext.getInstance().Pravno.Attach(pravno);            
            var pravnoDb = licitacijaDBContext.Pravno.Find(pravno.LiceId);
            licitacijaDBContext.Pravno.Remove(pravnoDb);
            licitacijaDBContext.SaveChanges();
        }

        protected override void proveriPreduslov(Pravno pravno)
        {
            
        }
    }
}
