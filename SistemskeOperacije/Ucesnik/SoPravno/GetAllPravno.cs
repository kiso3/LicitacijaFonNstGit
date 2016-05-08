using DomenskeKlase.Ucenik;
using System.Collections.Generic;
using System.Linq;

namespace SistemskeOperacije.Ucesnik.SoPravno
{
    public class GetAllPravno : OpstaSo<Pravno>
    {
        private List<Pravno> list;

        protected override void izvrsiKonkretnuOperaciju(Pravno pravno)
        {
            list = licitacijaDBContext.Pravno.Include("Mesto").ToList();
        }

        protected override void proveriPreduslov(Pravno pravno)
        {
            
        }

        public List<Pravno> GetList()
        {
            return list;
        }

    }
}
