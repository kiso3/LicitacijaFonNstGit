using DomenskeKlase.Licitacija;
using DomenskeKlase.LicitacijaPriprema;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace SistemskeOperacije.SoPrijava
{
    public class GetAllPrijaveForNademtanje : OpstaSo<Nadmetanje>
    {
        private List<Prijava> list;

        protected override void izvrsiKonkretnuOperaciju(Nadmetanje nadmetanje)
        {
            
            list = licitacijaDBContext.Prijava
                                          .OfType<PrijavaPravno>()
                                          .Include(p => p.Pravno.Mesto)
                                          .Where(p => p.Nadmetanje.NadmetanjeId == nadmetanje.NadmetanjeId)
                                          .Cast<Prijava>()
                                          .ToList();

            list.AddRange(licitacijaDBContext.Prijava
                                                .OfType<PrijavaFizicko>()
                                                .Include(p => p.Fizicko.Mesto)
                                                .Where(p => p.Nadmetanje.NadmetanjeId == nadmetanje.NadmetanjeId)
                                                .Cast<Prijava>()
                                                .ToList());

        }

        protected override void proveriPreduslov(Nadmetanje entity)
        {
            
        }

        public List<Prijava> GetList()
        {
            return list;
        }
    }
}
