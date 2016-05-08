using DomenskeKlase.Ucenik;

namespace SistemskeOperacije.Ucesnik.SoFizicko
{
    public class DeleteFizicko : OpstaSo<Fizicko>
    {
        protected override void izvrsiKonkretnuOperaciju(Fizicko fizicko)
        {
            //LicitacijaDBContext.getInstance().Fizicko.Attach(fizicko);
            var fizickoDb = licitacijaDBContext.Fizicko.Find(fizicko.LiceId);
            licitacijaDBContext.Fizicko.Remove(fizickoDb);
            licitacijaDBContext.SaveChanges();
        }

        protected override void proveriPreduslov(Fizicko entity)
        {
           
        }
    }
}
