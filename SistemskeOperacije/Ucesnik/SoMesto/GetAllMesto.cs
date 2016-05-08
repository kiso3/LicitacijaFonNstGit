using DomenskeKlase.Ucenik;
using System.Collections.Generic;
using System.Linq;

namespace SistemskeOperacije.Ucesnik.SoMesto
{
    public class GetAllMesto : OpstaSo<Mesto>
    {
        private List<Mesto> list;

        protected override void izvrsiKonkretnuOperaciju(Mesto mesto)
        {
                      
            list = licitacijaDBContext.Mesto.ToList();

        }

        protected override void proveriPreduslov(Mesto mesto)
        {
            
        }

        public List<Mesto> GetList()
        {
            return list;
        }



    }
}
