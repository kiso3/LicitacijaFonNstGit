using DomenskeKlase.LicitacijaPriprema;
using System.Collections.Generic;
using System.Linq;

namespace SistemskeOperacije.LicitacijaPriprema.SoResenje
{
    public class GetAllResenje : OpstaSo<Resenje>
    {

        private List<Resenje> list;

        protected override void izvrsiKonkretnuOperaciju(Resenje entity)
        {

            list = licitacijaDBContext.Resenje//.AsEnumerable()
                                                .Include("Oglas")
                                                .Where(r => r.Oglas != null)
                                                .ToList()
                                                .Select(r =>
                                                {
                                                    if (r != null)
                                                    {
                                                        return new Resenje()
                                                        {
                                                            ResenjeId = r.ResenjeId,
                                                            DarumIzradeResenja = r.DarumIzradeResenja,
                                                            ClasnStatuta = r.ClasnStatuta,
                                                            DaumSednice = r.DaumSednice,
                                                            SluzbeniListBr = r.SluzbeniListBr,
                                                            TekstOdluke = r.TekstOdluke,
                                                            ZaGodinu = r.ZaGodinu,
                                                            Oglas = new Oglas()
                                                            {
                                                                OglasId = r.Oglas.OglasId,
                                                                DatumObjave = r.Oglas.DatumObjave,
                                                                MaxpovZakupa = r.Oglas.MaxpovZakupa,
                                                                Resenje = null,
                                                                NadmetanjeList = null
                                                            }
                                                        };
                                                    }
                                                    else { return null; }
                                                })
                                                .ToList()
                                                ;

        }

        protected override void proveriPreduslov(Resenje entity)
        {
            
        }


        public List<Resenje> Getlist()
        {
            return list;
        }
    }

}
