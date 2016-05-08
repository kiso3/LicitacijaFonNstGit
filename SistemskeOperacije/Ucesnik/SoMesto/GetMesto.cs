using DomenskeKlase.Ucenik;
using System.Linq;

namespace SistemskeOperacije.Ucesnik.SoMesto
{
    public class GetMesto : OpstaSo<Mesto>
    {
        private Mesto mesto;

        protected override void izvrsiKonkretnuOperaciju(Mesto mesto)
        {
            this.mesto = licitacijaDBContext.Mesto.FirstOrDefault(x => x.MestoId == mesto.MestoId);
        }

        protected override void proveriPreduslov(Mesto entity)
        {
            
        }

        public Mesto GetObject()
        {
            return this.mesto;
        }
    }
}
