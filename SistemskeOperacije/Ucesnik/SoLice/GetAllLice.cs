using DomenskeKlase.Ucenik;
using System.Collections.Generic;
using System.Linq;

namespace SistemskeOperacije.Ucesnik.SoLice
{
    public class GetAllLice : OpstaSo<Lice>
    {

        private List<Lice> list;

        protected override void izvrsiKonkretnuOperaciju(Lice lice)
        {            
            list = licitacijaDBContext.Lice.Include("Mesto").ToList();           
        }

        protected override void proveriPreduslov(Lice entity)
        {
            
        }

        public List<Lice> GetList()
        {
            return list;
        }
    }
}
