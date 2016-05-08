using DomenskeKlase.Ucenik;
using System.Linq;

namespace SistemskeOperacije.Ucesnik.SoPravno
{
    public class GetPravno : OpstaSo<Pravno>
    {
        private Pravno pravno;

        protected override void izvrsiKonkretnuOperaciju(Pravno pravno)
        {
            this.pravno = licitacijaDBContext.Pravno.Include("Mesto").FirstOrDefault(x => x.Mb == pravno.Mb);
        }

        protected override void proveriPreduslov(Pravno pravno)
        {
            if (pravno.Mb == null || pravno.Mb.Equals(""))
            {
                throw new System.ArgumentException("Mb ne moze bitu null ili prazan");
            }
        }

        public Pravno GetObject()
        {
            return this.pravno;
        }
    }
}
