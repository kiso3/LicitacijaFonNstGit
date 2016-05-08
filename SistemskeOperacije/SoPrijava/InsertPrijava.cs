using DomenskeKlase.Licitacija;
using System.Linq;

namespace SistemskeOperacije.LicitacijaPriprema.SoPrijavaPravno
{
    public class InsertPrijava : OpstaSo<Prijava>
    {
        protected override void izvrsiKonkretnuOperaciju(Prijava prijava)
        {

            if (prijava is PrijavaFizicko)
            {
                PrijavaFizicko prijavaFizicko = (PrijavaFizicko)prijava;
                prijavaFizicko.Fizicko = licitacijaDBContext.Fizicko.Single(p => p.LiceId == prijavaFizicko.Fizicko.LiceId);
            }
            else 
            {
                PrijavaPravno prijavaPravno = (PrijavaPravno)prijava;
                prijavaPravno.Pravno = licitacijaDBContext.Pravno.Single(p => p.LiceId == prijavaPravno.Pravno.LiceId);                
            }

            prijava.Nadmetanje = licitacijaDBContext.Nadmetanje.Single(n => n.NadmetanjeId == prijava.Nadmetanje.NadmetanjeId);
            
            licitacijaDBContext.Prijava.Add(prijava);
            licitacijaDBContext.SaveChanges();
        }

        protected override void proveriPreduslov(Prijava entity)
        {
            
        }
    }
}
