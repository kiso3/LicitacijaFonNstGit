using DomenskeKlase.LicitacijaPriprema;
using DomenskeKlase.Ucenik;
using System.Collections.Generic;
using System.Linq;

namespace SistemskeOperacije.SoPrijava
{
    public class GetAllLicaForPrijava : OpstaSo<Nadmetanje>
    {
        private List<Lice> list;
        private List<int> listPrijavaFizicko;
        private List<int> listPrijavaPravno;
        protected override void izvrsiKonkretnuOperaciju(Nadmetanje nadmetanje)
        {
          

            listPrijavaFizicko = licitacijaDBContext.PrijavaFizicko.Where(
                p1 => (licitacijaDBContext.Prijava.Where(p => p.Nadmetanje.NadmetanjeId == nadmetanje.NadmetanjeId)
                        .Select(p => p.PrijavaId)
                        .Contains(p1.PrijavaId)))                           
                .Select(p => p.Fizicko.LiceId)
                .ToList();

            listPrijavaPravno = licitacijaDBContext.PrijavaPravno.Where(
                p1 => (licitacijaDBContext.Prijava.Where(p => p.Nadmetanje.NadmetanjeId == nadmetanje.NadmetanjeId)
                    .Select(p => p.PrijavaId)
                    .Contains(p1.PrijavaId)))
                .Select(p => p.Pravno.LiceId)
                .ToList();

            List<int> listPrijaveUnion = listPrijavaFizicko.Union(listPrijavaPravno).ToList();

            list = licitacijaDBContext.Lice.Include("Mesto")
                 .Where(x => !listPrijaveUnion.Contains(x.LiceId))                        
                 .ToList();            
        }

        protected override void proveriPreduslov(Nadmetanje entity)
        {
            
        }

        public List<Lice> GetList()
        {
            return list;
        }
    }
}
