using DomenskeKlase.Licitacija;
using DomenskeKlase.LicitacijaPriprema;
using System.Linq;
using System.Data.Entity;

namespace SistemskeOperacije.LicitacijaPriprema.GetNadmetanje
{
    public class GetNadmetanje : OpstaSo<Nadmetanje>
    {
        private Nadmetanje nadmetanje;

        protected override void izvrsiKonkretnuOperaciju(Nadmetanje nadmetanje)
        {

            this.nadmetanje = licitacijaDBContext.Nadmetanje
                                                .Include(p => p.PrijavaList)                                                                                            
                                                .First(n => n.NadmetanjeId == nadmetanje.NadmetanjeId);

            foreach (var item in this.nadmetanje.PrijavaList)
                if (item is PrijavaFizicko)
                {
                    licitacijaDBContext.Entry(item).Reference(a => ((PrijavaFizicko)a).Fizicko).Load();
                    licitacijaDBContext.Entry(item).Reference(a => ((PrijavaFizicko)a).Fizicko).Query().Select(b => b.Mesto).Load();
                }
                else
                {
                    licitacijaDBContext.Entry(item).Reference(a => ((PrijavaPravno)a).Pravno).Load();
                    licitacijaDBContext.Entry(item).Reference(a => ((PrijavaPravno)a).Pravno).Query().Select(b => b.Mesto).Load();
                }

            //List<PrijavaPravno> prijavaPravno = licitacijaDBContext.PrijavaPravno.Include(p => p.Pravno.Mesto).Where(p => p.Nadmetanje.NadmetanjeId == nadmetanje.NadmetanjeId).ToList();
            //List<PrijavaFizicko> prijavaFizicko = licitacijaDBContext.PrijavaFizicko.Include(p => p.Fizicko.Mesto).Where(p => p.Nadmetanje.NadmetanjeId == nadmetanje.NadmetanjeId).ToList();

            
        }

        protected override void proveriPreduslov(Nadmetanje entity)
        {
            
        }

        public Nadmetanje GetObject()
        {
            return nadmetanje;
        }
    }
}
