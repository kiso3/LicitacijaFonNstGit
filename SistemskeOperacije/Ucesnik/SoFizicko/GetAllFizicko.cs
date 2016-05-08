using DomenskeKlase.Ucenik;
using System.Collections.Generic;
using System.Linq;

namespace SistemskeOperacije.Ucesnik.SoFizicko
{
    public class GetAllFizicko : OpstaSo<Fizicko>
    {
        private List<Fizicko> list;
       
        protected override void izvrsiKonkretnuOperaciju(Fizicko fizicko)
        {
            list = licitacijaDBContext.Fizicko.Include("Mesto").ToList();
        }

        protected override void proveriPreduslov(Fizicko fizicko)
        {
            
        }

        public List<Fizicko> GetList()
        {
            return list;
        }
    }
}
