using DomenskeKlase.Ucenik;
using System.Linq;

namespace SistemskeOperacije.Ucesnik.SoMesto
{
    public class InsertMesto : OpstaSo<Mesto>
    {

        protected override void izvrsiKonkretnuOperaciju(Mesto mesto)
        {
            licitacijaDBContext.Mesto.Add(mesto);
            licitacijaDBContext.SaveChanges();
        }

        protected override void proveriPreduslov(Mesto mesto)
        {
            if(mesto.Naziv == null || mesto.Naziv.Equals(""))
            {
                throw new System.ArgumentException("Naziv ne moze bitu null ili prazan");
            }

            Mesto mestoDb = licitacijaDBContext.Mesto.FirstOrDefault(x => x.Naziv == mesto.Naziv);
            if (mestoDb != null)
            {
                throw new System.ApplicationException("Entitet postoji");
            }
        }
    }
}
