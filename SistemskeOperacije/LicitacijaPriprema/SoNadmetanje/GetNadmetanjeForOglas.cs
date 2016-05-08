using DomenskeKlase.LicitacijaPriprema;
using System.Collections.Generic;
using System.Linq;

namespace SistemskeOperacije.LicitacijaPriprema.SoNadmetanje
{
    public class GetAllNadmetanjeForOglas : OpstaSo<Oglas>
    {
        private List<Nadmetanje> list;
     
        protected override void izvrsiKonkretnuOperaciju(Oglas oglas)
        {
            /*
            list =  (licitacijaDBContext.Oglas
                                        .Include("NadmetanjeList")
                                        .Where(o => o.OglasId == oglas.OglasId ).First())
                                            .NadmetanjeList
                                            .ToList();  
            */
            list = licitacijaDBContext.Nadmetanje                                        
                                       .Where(o => o.Oglas.OglasId == oglas.OglasId)                                       
                                       .ToList()
                                       .Select(n =>
                                       {
                                           if(n != null)
                                           {
                                               return new Nadmetanje()
                                               {
                                                   DatumNadmetanja = n.DatumNadmetanja,
                                                   Depozit = n.Depozit,
                                                   Kompleks = null,
                                                   NadmetanjeId = n.NadmetanjeId,                                                   
                                                   OznakaNadmetanja = n.OznakaNadmetanja,
                                                   PeriodZakupa = n.PeriodZakupa,
                                                   PocetnaCena = n.PocetnaCena,
                                                   PrijavaList = null,
                                                   Oglas = new Oglas()
                                                   {
                                                       OglasId = n.Oglas.OglasId,
                                                       DatumObjave = n.Oglas.DatumObjave,
                                                       MaxpovZakupa = n.Oglas.MaxpovZakupa,
                                                       NadmetanjeList = null,
                                                       Resenje = null
                                                       //new Resenje()
                                                       //{
                                                       //    ClasnStatuta = n.Oglas.Resenje.ClasnStatuta,
                                                       //    DarumIzradeResenja = n.Oglas.Resenje.DarumIzradeResenja,
                                                       //    DaumSednice = n.Oglas.Resenje.DaumSednice,
                                                       //    ResenjeId = n.Oglas.Resenje.ResenjeId,
                                                       //    SluzbeniListBr = n.Oglas.Resenje.SluzbeniListBr,
                                                       //    TekstOdluke = n.Oglas.Resenje.TekstOdluke
                                                       //}
                                                   }
                                               };
                                           }
                                           else
                                           {
                                               return null;
                                           }
                                       }).ToList();
             
        }

        protected override void proveriPreduslov(Oglas oglas)
        {
            
        }

        public List<Nadmetanje> GetList()
        {
            return list;
        }
    }
}
